using Microsoft.ML;
using System;
using System.Linq;
using ProductRecommender.PredictionModels;
using ProductRecommender.Models;
using System.Collections.Generic;
using Microsoft.ML.Trainers;
using static Microsoft.ML.DataOperationsCatalog;

namespace ProductRecommender
{
    class Program
    {
        private static DataContext DataContext = new DataContext();
        private static MLContext MLContext = new MLContext();

        static void Main(string[] args)
        {
            IEnumerable<ProductEntry> purchaseEntries = FetchPurchaseEntries();
            Console.WriteLine(purchaseEntries.Count());
            var partitions = LoadAndPartitionData(purchaseEntries);
            var model = BuildAndTrainModel(partitions.TrainSet);
            EvaluateModel(model, partitions.TestSet);

            // use model
            var predictionEngine = MLContext.Model.CreatePredictionEngine<ProductEntry, CoPurchasePrediction>(model);
            List<uint> products = purchaseEntries.Select(x => x.ProductId).Distinct().ToList();

            uint product = products[0];
            List<uint> suggestedProduct = products
                .OrderByDescending(p => predictionEngine.Predict(new ProductEntry { ProductId = product, CoPurchaseProductId = p }).Score)
                .Take(5).ToList();
            Console.WriteLine(product);
            foreach(uint p in suggestedProduct)
            {
                float Score = predictionEngine.Predict(new ProductEntry { ProductId = product, CoPurchaseProductId = p }).Score;
                Console.WriteLine(p + " " + Score);
            }

        }

        private static IEnumerable<ProductEntry> FetchPurchaseEntries()
        {
            var transactionQuery = DataContext.Fact_DirectSalesOrderTransaction
                .Where(t => t.DeletedAt == null);

            var indirectTransactionQuery = DataContext.Fact_IndirectSalesOrderTransaction
                .Where(t => t.DeletedAt == null);

            List<Fact_DirectSalesOrderTransaction> directTransactions = transactionQuery.ToList();
            List<Fact_IndirectSalesOrderTransaction> indirectTransactions = indirectTransactionQuery.ToList();
            var directGroups = from t in directTransactions
                         group t by t.DirectSalesOrderId;

            var indirectGroups = from t in indirectTransactions
                                 group t by t.IndirectSalesOrderId;

            IEnumerable<ProductEntry> directQueryable =
                from g in directGroups
                from t1 in g
                from t2 in g
                where t1.ItemId != t2.ItemId
                select new ProductEntry
                {
                    ProductId = (uint)t1.ItemId,
                    CoPurchaseProductId = (uint)t2.ItemId
                };

            IEnumerable<ProductEntry> indirectQueryable =
                from g in indirectGroups
                from t1 in g
                from t2 in g
                where t1.ItemId != t2.ItemId
                select new ProductEntry
                {
                    ProductId = (uint)t1.ItemId,
                    CoPurchaseProductId = (uint)t2.ItemId
                };

            return directQueryable.Concat(indirectQueryable);
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
            Console.WriteLine($"  RMSE: {metrics.RSquared:#.##}");
        }

    }
}
