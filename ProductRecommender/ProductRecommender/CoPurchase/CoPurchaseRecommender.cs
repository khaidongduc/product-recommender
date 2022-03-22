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

        public IEnumerable<CoPurchaseProductEntry> FetchEntries()
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

            IEnumerable<CoPurchaseProductEntry> directQueryable =
                from g in directGroups
                from t1 in g
                from t2 in g
                where t1.ItemId != t2.ItemId
                select new CoPurchaseProductEntry
                {
                    ProductId = (uint)t1.ItemId,
                    CoPurchaseProductId = (uint)t2.ItemId
                };

            IEnumerable<CoPurchaseProductEntry> indirectQueryable =
                from g in indirectGroups
                from t1 in g
                from t2 in g
                where t1.ItemId != t2.ItemId
                select new CoPurchaseProductEntry
                {
                    ProductId = (uint)t1.ItemId,
                    CoPurchaseProductId = (uint)t2.ItemId
                };

            return directQueryable.Concat(indirectQueryable);
        }

        public TrainTestData LoadAndPartitionData(IEnumerable<CoPurchaseProductEntry> purchaseEntries)
        {
            var data = MLContext.Data.LoadFromEnumerable(purchaseEntries);
            var partitions = MLContext.Data.TrainTestSplit(data, testFraction: 0.2);
            return partitions;
        }

        public ITransformer BuildAndTrainModel(IDataView trainDataSet)
        {
            MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options()
            {
                MatrixColumnIndexColumnName = nameof(CoPurchaseProductEntry.ProductId),
                MatrixRowIndexColumnName = nameof(CoPurchaseProductEntry.CoPurchaseProductId),
                LabelColumnName = nameof(CoPurchaseProductEntry.Label),
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
        
        public PredictionEngine<CoPurchaseProductEntry, CoPurchasePrediction> CreatePredictEngine(ITransformer model)
        {
            return MLContext.Model.CreatePredictionEngine<CoPurchaseProductEntry, CoPurchasePrediction>(model);
        }

    }
}
