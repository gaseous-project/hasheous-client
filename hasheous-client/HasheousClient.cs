using HasheousClient.Models;

namespace HasheousClient
{
    public class Hasheous
    {
        public LookupItemModel RetrieveFromHasheous(HashLookupModel hash)
        {
            Task<LookupItemModel> result = _RetrieveFromHasheousAsync(hash);   

            return result.Result;
        }

        private async Task<LookupItemModel> _RetrieveFromHasheousAsync(HashLookupModel hashLookup)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Post<LookupItemModel>($"/api/v1/Lookup/ByHash", hashLookup);

            return result;
        }

        public FixMatchModel FixMatch(FixMatchModel model)
        {
            Task<FixMatchModel> result = _FixMatchAsync(model);   

            return result.Result;
        }

        private async Task<FixMatchModel> _FixMatchAsync(FixMatchModel model)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Post<FixMatchModel>($"/api/v1/Submissions/FixMatch", model);

            return result;
        }
    }
}