using Microsoft.ML;
using System;
using System.Linq;
using ContentBasedRS.PredictionModels;
using ContentBasedRS.Models;
using System.Collections.Generic;
using Microsoft.ML.Trainers;
using Microsoft.ML.Data;
using static Microsoft.ML.DataOperationsCatalog;

namespace ContentBasedRS
{
    class Program
    {
        private static DataContext DataContext = new DataContext();
        private static MLContext MLContext = new MLContext();

        static void Main(string[] args)
        {
            IEnumerable<ProductEntry> purchaseEntries = FetchPurchaseEntries();
            var partitions = LoadAndPartitionData(purchaseEntries);
            var model = BuildAndTrainModel(partitions.TrainSet);
            EvaluateModel(model, partitions.TestSet);

            // use model
            var predictionEngine = MLContext.Model.CreatePredictionEngine<ProductEntry, CoPurchasePrediction>(model);
            List<uint> products = purchaseEntries.Select(x => x.ProductId).ToList();

            int i = 0, j = 0;
            Console.WriteLine(products[i] + " " + products[j] + " " + predictionEngine.Predict(new ProductEntry
            {
                ProductId = products[i],
                CoPurchaseProductId = products[j]
            }).Score);

        }

        private static IEnumerable<ProductEntry> FetchPurchaseEntries()
        {
            var transactionQuery = DataContext.Fact_DirectSalesOrderTransaction
                .Where(t => t.DeletedAt == null);
            List<Fact_DirectSalesOrderTransaction> transactions = transactionQuery.ToList();
            var groups = from t in transactions
                         group t by t.DirectSalesOrderId;
            
            IEnumerable<ProductEntry> queryable =
                from g in groups
                from t1 in g
                from t2 in g
                where t1.DirectSalesOrderTransactionId != t2.DirectSalesOrderTransactionId
                select new ProductEntry
                {
                    ProductId = (uint)t1.ItemId,
                    CoPurchaseProductId = (uint)t2.ItemId
                };

            return queryable;
        }

        private static TrainTestData LoadAndPartitionData(IEnumerable<ProductEntry> purchaseEntries)
        {
            var data = MLContext.Data.LoadFromEnumerable(purchaseEntries);
            var partitions = MLContext.Data.TrainTestSplit(data, testFraction: 0.2);
            return partitions;
        }

        private static ITransformer BuildAndTrainModel(IDataView trainDataSet)
        {
            MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options()
            {
                MatrixColumnIndexColumnName = nameof(ProductEntry.ProductId),
                MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductId),
                LabelColumnName = nameof(ProductEntry.Label),
                LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                Alpha = 0.01,
                Lambda = 0.025,
                NumberOfIterations = 10,
                C = 0.00001,
            };
            var estimator = MLContext.Recommendation().Trainers.MatrixFactorization(options);
            ITransformer model = estimator.Fit(trainDataSet);
            return model;
        }

        private static void EvaluateModel(ITransformer model, IDataView testDataSet)
        {
            var predictions = model.Transform(testDataSet);
            var metrics = MLContext.Regression.Evaluate(predictions);
            Console.WriteLine($"  RMSE: {metrics.RootMeanSquaredError:#.##}");
        }

    }
}
