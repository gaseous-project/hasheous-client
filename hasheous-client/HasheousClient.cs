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

        public List<DataObjectItem> GetPlatforms()
        {
            Task<List<DataObjectItem>> result = _GetPlatformsAsync();

            return result.Result;
        }

        private async Task<List<DataObjectItem>> _GetPlatformsAsync()
        {
            var result = await HasheousClient.WebApp.HttpHelper.Get<DataObjectsList>($"/api/v1/Lookup/Platforms?PageSize=50&PageNumber=1");

            if (result == null)
            {
                return new List<DataObjectItem>();
            }
            else
            {
                if (result.TotalPages > 1)
                {
                    for (int i = 2; i <= result.TotalPages; i++)
                    {
                        var nextResult = await HasheousClient.WebApp.HttpHelper.Get<DataObjectsList>($"/api/v1/Lookup/Platforms?PageSize=50&PageNumber={i}");

                        if (nextResult != null)
                        {
                            result.Objects.AddRange(nextResult.Objects);
                        }
                    }
                }

                return result.Objects;
            }
        }
    }
}