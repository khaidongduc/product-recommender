using System;
using System.Collections.Generic;
using System.Text;

namespace ProductRecommender.FieldAwareFactorization
{
    class FAFPrediction
    {
        public bool Label { get; set; }

        public bool PredictedLabel { get; set; }
        
        public float Score { get; set; }

        public float Probability { get; set; }
    }
}
