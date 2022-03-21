using Microsoft.ML;
using System;
using System.Linq;
using ContentBasedRS.PredictionModels;
using ContentBasedRS.Models;
using System.Collections.Generic;
using Microsoft.ML.Trainers;

namespace ContentBasedRS
{
    class Program
    {
        public static int NUM_DATA = 100;

        private static DataContext DataContext = new DataContext();
        private static MLContext MLContext = new MLContext();

        static void Main(string[] args)
        {
            IEnumerable<ProductPurchaseEntry> purchaseEntries = FetchPurchaseEntries();

            var data = MLContext.Data.LoadFromEnumerable(purchaseEntries);




        }

        private static IEnumerable<ProductPurchaseEntry> FetchPurchaseEntries()
        {
            var transactionQuery = DataContext.Fact_DirectSalesOrderTransaction
                .Where(t => t.DeletedAt == null)
                .Take(NUM_DATA);
            List<Fact_DirectSalesOrderTransaction> transactions = transactionQuery.ToList();
            var groups = from t in transactions
                         group t by t.DirectSalesOrderId;
            
            IEnumerable<ProductPurchaseEntry> queryable =
                from g in groups
                from t1 in g
                from t2 in g
                where t1.DirectSalesOrderTransactionId != t2.DirectSalesOrderTransactionId
                select new ProductPurchaseEntry
                {
                    ProductId = (uint)t1.ItemId,
                    CoPurchaseProductId = (uint)t2.ItemId
                };

            return queryable;
        }

    }
}
