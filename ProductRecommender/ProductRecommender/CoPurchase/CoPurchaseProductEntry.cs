using Microsoft.ML.Data;

namespace ProductRecommender.CoPurchase
{
    class CoPurchaseProductEntry
    {
        [KeyType(count: 262111)]
        public uint ProductId { get; set; }

        [KeyType(count: 262111)]
        public uint CoPurchaseProductId { get; set; }

        public float Label; // required

    }
}
