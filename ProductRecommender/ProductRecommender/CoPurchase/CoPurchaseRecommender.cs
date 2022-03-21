using Microsoft.ML;
using System;
using System.Linq;
using ProductRecommender.Models;
using System.Collections.Generic;
using Microsoft.ML.Trainers;
using static Microsoft.ML.DataOperationsCatalog;

namespace ProductRecommender.CoPurchase
{
    class CoPurchaseRecommender
    {
        private DataContext DataContext;
        private MLContext MLContext;

        public CoPurchaseRecommender()
        {
            DataContext = new DataContext();
            MLContext = new MLContext();
        }

        public IEnumerable<ProductEntry> FetchPurchaseEntries()
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

        public TrainTestData LoadAndPartitionData(IEnumerable<ProductEntry> purchaseEntries)
        {
            var data = MLContext.Data.LoadFromEnumerable(purchaseEntries);
            var partitions = MLContext.Data.TrainTestSplit(data, testFraction: 0.2);
            return partitions;
        }

        public ITransformer BuildAndTrainModel(IDataView trainDataSet)
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

        public void EvaluateModel(ITransformer model, IDataView testDataSet)
        {
            var predictions = model.Transform(testDataSet);
            var metrics = MLContext.Regression.Evaluate(predictions);
            Console.WriteLine($"  RMSE: {metrics.RootMeanSquaredError:#.##}");
            Console.WriteLine($"  RSquare: {metrics.RSquared:#.##}");
        }
        
        public PredictionEngine<ProductEntry, CoPurchasePrediction> CreatePredictEngine(ITransformer model)
        {
            return MLContext.Model.CreatePredictionEngine<ProductEntry, CoPurchasePrediction>(model);
        }

    }
}
