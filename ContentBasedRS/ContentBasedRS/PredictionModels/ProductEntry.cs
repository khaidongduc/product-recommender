using Microsoft.ML.Data;

namespace ContentBasedRS.PredictionModels
{
    class ProductEntry
    {
        [KeyType(count: 262111)]
        public uint ProductId { get; set; }

        [KeyType(count: 262111)]
        public uint CoPurchaseProductId { get; set; }

        public float Label; // required

    }
}
