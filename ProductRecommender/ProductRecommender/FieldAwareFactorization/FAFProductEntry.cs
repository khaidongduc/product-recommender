using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductRecommender.FieldAwareFactorization
{
    class FAFProductEntry
    {

        public string ProductId { get; set; }

        public string CoPurchaseProductId { get; set; }

        public float ProductQuantity { get; set; }

        public bool Label; // required

    }
}
