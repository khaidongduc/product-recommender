using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentBasedRS.PredictionModels
{
    class ProductEntry
    {
        [KeyType(count: 262111)]
        public uint ProductId { get; set; }

        [KeyType(count: 262111)]
        public uint CoPurchaseProductId { get; set; }

        public float Label;

    }
}
