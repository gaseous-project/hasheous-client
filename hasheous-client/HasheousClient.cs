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

        public T GetMetadataProxy<T>(MetadataProvider metadataProvider, int id)
        {
            Task<T> result = _GetMetadataProxy<T>(metadataProvider, id);

            return result.Result;
        }

        private async Task<T> _GetMetadataProxy<T>(MetadataProvider metadataProvider, int id)
        {
            string TypeName = typeof(T).Name;

            var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/{TypeName}?id={id}");

            return result;
        }

        public T? GetMetadataProxy_SearchPlatform<T>(MetadataProvider metadataProvider, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (TypeName == "Platform" && metadataProvider == MetadataProvider.IGDB)
            {
                Task<T> result = _GetMetadataProxy_SearchPlatform<T>(metadataProvider, search);

                return result.Result;
            }

            return default;
        }

        private async Task<T> _GetMetadataProxy_SearchPlatform<T>(MetadataProvider metadataProvider, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/Search/{TypeName}?SearchString={search}");

            return result;
        }

        public T? GetMetadataProxy_SearchGame<T>(MetadataProvider metadataProvider, string platformId, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (TypeName == "Game" && metadataProvider == MetadataProvider.IGDB)
            {
                Task<T> result = _GetMetadataProxy_SearchGame<T>(metadataProvider, platformId, search);

                return result.Result;
            }

            return default;
        }

        private async Task<T> _GetMetadataProxy_SearchGame<T>(MetadataProvider metadataProvider, string platformId, string search)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/Search/Platform/{platformId}/Game?SearchString={search}");

            return result;
        }

        public enum MetadataProvider
        {
            IGDB
        }
    }
}