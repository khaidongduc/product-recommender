using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.ML.DataOperationsCatalog;

namespace ProductRecommender.FieldAwareFactorization
{
    class FAFRecommender
    {
        internal IEnumerable<FAFProductEntry> FetchEntries()
        {
            throw new NotImplementedException();
        }

        internal TrainTestData LoadAndPartitionData(IEnumerable<FAFProductEntry> purchaseEntries)
        {
            throw new NotImplementedException();
        }

        internal ITransformer BuildAndTrainModel(IDataView trainSet)
        {
            throw new NotImplementedException();
        }

        internal void EvaluateModel(ITransformer model, IDataView testSet)
        {
            throw new NotImplementedException();
        }

        internal PredictionEngine<FAFProductEntry, FAFPrediction> CreatePredictEngine(ITransformer model)
        {
            throw new NotImplementedException();
        }
    }
}
