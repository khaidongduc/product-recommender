using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductRecommender.FieldAwareFactorization
{
    class FAFProductEntry
    {
        public uint UserId { get; set; }

        public uint ProductId { get; set; }

        public uint CoPurchaseProductId { get; set; }

        public float ProductQuantity { get; set; }

        public float Label; // required

    }
}
