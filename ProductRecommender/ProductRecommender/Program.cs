using System;
using System.Linq;
using System.Collections.Generic;
using ProductRecommender.CoPurchase;
using ProductRecommender.FieldAwareFactorization;

namespace ProductRecommender
{
    class Program
    {

        static void CoPurchase()
        {
            var recommender = new CoPurchaseRecommender();

            IEnumerable<CoPurchaseProductEntry> purchaseEntries = recommender.FetchEntries();
            Console.WriteLine(purchaseEntries.Count());
            var partitions = recommender.LoadAndPartitionData(purchaseEntries);
            var model = recommender.BuildAndTrainModel(partitions.TrainSet);
            recommender.EvaluateModel(model, partitions.TestSet);

            // use model
            var predictionEngine = recommender.CreatePredictEngine(model);
            List<uint> products = purchaseEntries.Select(x => x.ProductId).Distinct().ToList();

            uint product = products[0];
            Func<uint, float> predictScore = p => predictionEngine.Predict(new CoPurchaseProductEntry
            {
                ProductId = product,
                CoPurchaseProductId = p
            }).Score;
            List<uint> suggestedProduct = products
                .OrderByDescending(p => predictScore(p))
                .Take(5).ToList();
            Console.WriteLine(product);
            foreach (uint p in suggestedProduct)
            {
                float Score = predictionEngine.Predict(
                    new CoPurchaseProductEntry
                    {
                        ProductId = product,
                        CoPurchaseProductId = p
                    }).Score;
                Console.WriteLine(p + " " + Score);
            }
        }

        static void FieldAwareFactorization()
        {
            var recommender = new FAFRecommender();

            IEnumerable<FAFProductEntry> purchaseEntries = recommender.FetchEntries();
            Console.WriteLine(purchaseEntries.Count());
            var partitions = recommender.LoadAndPartitionData(purchaseEntries);
            var model = recommender.BuildAndTrainModel(partitions.TrainSet);
            recommender.EvaluateModel(model, partitions.TestSet);

            // use model
            var predictionEngine = recommender.CreatePredictEngine(model);
            List<String> products = purchaseEntries.Select(x => x.ProductId.ToString()).Distinct().ToList();

            var product = purchaseEntries.FirstOrDefault();
            Func<String, float> predictScore = p => predictionEngine.Predict(new FAFProductEntry
            {
                ProductId = product.ProductId,
                CoPurchaseProductId = p,
                ProductQuantity = product.ProductQuantity, 
            }).Score;
            List<String> suggestedProduct = products
                .OrderByDescending(p => predictScore(p))
                .Take(5).ToList();
            Console.WriteLine(product);
            foreach (String p in suggestedProduct)
            {
                float Score = predictionEngine.Predict(
                    new FAFProductEntry
                    {
                        ProductId = product.ProductId,
                        CoPurchaseProductId = p.ToString(),
                        ProductQuantity = product.ProductQuantity,
                    }).Score;
                Console.WriteLine(p + " " + Score);
            }
        }

        static void Main(string[] args)
        {
            //CoPurchase();
            FieldAwareFactorization();
        }
    }
}
