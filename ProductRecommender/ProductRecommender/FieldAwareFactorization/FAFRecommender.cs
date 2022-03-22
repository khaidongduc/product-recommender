using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using ProductRecommender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Microsoft.ML.DataOperationsCatalog;

namespace ProductRecommender.FieldAwareFactorization
{
    class FAFRecommender
    {
        private DataContext DataContext;
        private MLContext MLContext;

        public FAFRecommender()
        {
            DataContext = new DataContext();
            MLContext = new MLContext();
        }


        public IEnumerable<FAFProductEntry> FetchEntries()
        {
            var transactionQuery = DataContext.Fact_DirectSalesOrderTransaction
                .Where(t => t.DeletedAt == null)
                .Take(50);

            var indirectTransactionQuery = DataContext.Fact_IndirectSalesOrderTransaction
                .Where(t => t.DeletedAt == null)
                .Take(50);

            List<Fact_DirectSalesOrderTransaction> directTransactions = transactionQuery.ToList();
            List<Fact_IndirectSalesOrderTransaction> indirectTransactions = indirectTransactionQuery.ToList();
            var directGroups = from t in directTransactions
                               group t by t.DirectSalesOrderId;

            var indirectGroups = from t in indirectTransactions
                                 group t by t.IndirectSalesOrderId;

            IEnumerable<FAFProductEntry> directQueryable =
                from g in directGroups
                from t1 in g
                from t2 in g
                where t1.ItemId != t2.ItemId
                select new FAFProductEntry
                {
                    ProductId = t1.ItemId.ToString(),
                    CoPurchaseProductId = t2.ItemId.ToString(),
                    ProductQuantity = (float)t1.Quantity,
                    Label = true,
                };

            IEnumerable<FAFProductEntry> indirectQueryable =
                from g in indirectGroups
                from t1 in g
                from t2 in g
                where t1.ItemId != t2.ItemId
                select new FAFProductEntry
                {
                    ProductId = t1.ItemId.ToString(),
                    CoPurchaseProductId = t2.ItemId.ToString(),
                    ProductQuantity = (float)t1.Quantity,
                    Label = true,
                };

            return directQueryable.Concat(indirectQueryable);
        }

        public TrainTestData LoadAndPartitionData(IEnumerable<FAFProductEntry> purchaseEntries)
        {
            var data = MLContext.Data.LoadFromEnumerable(purchaseEntries);
            var partitions = MLContext.Data.TrainTestSplit(data, testFraction: 0.2);
            return partitions;
        }

        public ITransformer BuildAndTrainModel(IDataView trainDataSet)
        {
            var options = new FieldAwareFactorizationMachineTrainer.Options
            {
                FeatureColumnName = nameof(FAFProductEntry.ProductId),
                ExtraFeatureColumns = new[]
                {
                    nameof(FAFProductEntry.CoPurchaseProductId),
                    nameof(FAFProductEntry.ProductQuantity),
                },
                LabelColumnName = nameof(FAFProductEntry.Label),
                LambdaLatent = 0.01f,
                LambdaLinear = 0.001f,
                LatentDimension = 16,
                NumberOfIterations = 50,
                LearningRate = 0.5f
            };
            var estimator = MLContext.BinaryClassification.Trainers.FieldAwareFactorizationMachine(options);
            ITransformer model = estimator.Fit(trainDataSet);
            return model;
        }

        public void EvaluateModel(ITransformer model, IDataView testDataSet)
        {
            var predictions = model.Transform(testDataSet);
            var metrics = MLContext.BinaryClassification.Evaluate(predictions);
            PrintMetrics(metrics);
        }

        public PredictionEngine<FAFProductEntry, FAFPrediction> CreatePredictEngine(ITransformer model)
        {
            var engine = MLContext.Model.CreatePredictionEngine<FAFProductEntry, FAFPrediction>(model);
            return engine;
        }


        private static void PrintMetrics(CalibratedBinaryClassificationMetrics metrics)
        {
            Console.WriteLine($"Accuracy: {metrics.Accuracy:F2}");
            Console.WriteLine($"AUC: {metrics.AreaUnderRocCurve:F2}");
            Console.WriteLine($"F1 Score: {metrics.F1Score:F2}");
            Console.WriteLine($"Negative Precision: " +
                $"{metrics.NegativePrecision:F2}");

            Console.WriteLine($"Negative Recall: {metrics.NegativeRecall:F2}");
            Console.WriteLine($"Positive Precision: " +
                $"{metrics.PositivePrecision:F2}");

            Console.WriteLine($"Positive Recall: {metrics.PositiveRecall:F2}");
            Console.WriteLine($"Log Loss: {metrics.LogLoss:F2}");
            Console.WriteLine($"Log Loss Reduction: {metrics.LogLossReduction:F2}");
            Console.WriteLine($"Entropy: {metrics.Entropy:F2}");
        }

    }
}
