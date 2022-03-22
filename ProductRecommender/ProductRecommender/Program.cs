using System;
using System.Linq;
using System.Collections.Generic;
using ProductRecommender.CoPurchase;

namespace ProductRecommender
{
    class Program
    {

        static void CoPurchase()
        {
            var recommender = new CoPurchaseRecommender();

            IEnumerable<CoPurchaseProductEntry> purchaseEntries = recommender.FetchPurchaseEntries();
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

        static void Main(string[] args)
        {
            //CoPurchase();

        }
    }
}
