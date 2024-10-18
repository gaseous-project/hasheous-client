using HasheousClient.Models;

namespace HasheousClient
{
    public class Hasheous
    {
        /// <summary>
        /// Retrieve a lookup item from Hasheous
        /// </summary>
        /// <param name="hash">
        /// The hash to lookup
        /// </param>
        /// <returns>
        /// The lookup item
        /// </returns>
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

        /// <summary>
        /// Fix a match in Hasheous
        /// </summary>
        /// <param name="model">
        /// The model to fix the match
        /// </param>
        /// <returns>
        /// The fixed match model
        /// </returns>
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

        /// <summary>
        /// Get a list of platforms from Hasheous
        /// </summary>
        /// <returns>
        /// A list of platforms
        /// </returns>
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

        /// <summary>
        /// Access the Hasheous Metadata Proxy
        /// </summary>
        /// <typeparam name="T">
        /// The type of metadata to retrieve
        /// </typeparam>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="id">
        /// The ID of the metadata to retrieve
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T GetMetadataProxy<T>(MetadataProvider metadataProvider, long id)
        {
            string TypeName = typeof(T).Name;

            Task<T> result = _GetMetadataProxy<T>(TypeName, metadataProvider, id);

            return result.Result;
        }

        /// <summary>
        /// Access the Hasheous Metadata Proxy
        /// </summary>
        /// <typeparam name="T">
        /// The type to load the metadata into
        /// </typeparam>
        /// <param name="TypeName">
        /// The name of the type of metadata to load
        /// </param>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="id">
        /// The ID of the metadata to load
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T GetMetadataProxy<T>(string TypeName, MetadataProvider metadataProvider, long id)
        {
            Task<T> result = _GetMetadataProxy<T>(TypeName, metadataProvider, id);

            return result.Result;
        }

        private async Task<T> _GetMetadataProxy<T>(string TypeName, MetadataProvider metadataProvider, long id)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/{TypeName}?id={id}");

            return result;
        }

        /// <summary>
        /// Access the Hasheous Metadata Proxy
        /// </summary>
        /// <typeparam name="T">
        /// The type to load the metadata into
        /// </typeparam>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="slug">
        /// The slug of the metadata to load
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T GetMetadataProxy<T>(MetadataProvider metadataProvider, string slug)
        {
            string TypeName = typeof(T).Name;

            Task<T> result = _GetMetadataProxy<T>(TypeName, metadataProvider, slug);

            return result.Result;
        }

        /// <summary>
        /// Access the Hasheous Metadata Proxy
        /// </summary>
        /// <typeparam name="T">
        /// The type to load the metadata into
        /// </typeparam>
        /// <param name="TypeName">
        /// The name of the type of metadata to load
        /// </param>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="slug">
        /// The slug of the metadata to load
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T GetMetadataProxy<T>(string TypeName, MetadataProvider metadataProvider, string slug)
        {
            Task<T> result = _GetMetadataProxy<T>(TypeName, metadataProvider, slug);

            return result.Result;
        }

        private async Task<T> _GetMetadataProxy<T>(string TypeName, MetadataProvider metadataProvider, string slug)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/{TypeName}?slug={slug}");

            return result;
        }

        /// <summary>
        /// Search the Hasheous Metadata Proxy for platform
        /// </summary>
        /// <typeparam name="T">
        /// The type to load the metadata into
        /// </typeparam>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="search">
        /// The search string to use
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T? GetMetadataProxy_SearchPlatform<T>(MetadataProvider metadataProvider, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T> result = _GetMetadataProxy_SearchPlatform<T>(TypeName, metadataProvider, search);

                return result.Result;
            }

            return default;
        }

        /// <summary>
        /// Search the Hasheous Metadata Proxy for platform
        /// </summary>
        /// <typeparam name="T">
        /// The type to load the metadata into
        /// </typeparam>
        /// <param name="TypeName">
        /// The name of the type of metadata to load
        /// </param>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="search">
        /// The search string to use
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T? GetMetadataProxy_SearchPlatform<T>(string TypeName, MetadataProvider metadataProvider, string search)
        {
            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T> result = _GetMetadataProxy_SearchPlatform<T>(TypeName, metadataProvider, search);

                return result.Result;
            }

            return default;
        }

        private async Task<T> _GetMetadataProxy_SearchPlatform<T>(string TypeName, MetadataProvider metadataProvider, string search)
        {
            if (TypeName == "Platform")
            {
                var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/Search/{TypeName}?SearchString={search}");

                return result;
            }
            else
            {
                throw new Exception("Invalid type for search");
            }
        }

        /// <summary>
        /// Search the Hasheous Metadata Proxy for game
        /// </summary>
        /// <typeparam name="T">
        /// The type to load the metadata into
        /// </typeparam>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="platformId">
        /// The ID of the platform to search within
        /// </param>
        /// <param name="search">
        /// The search string to use
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T? GetMetadataProxy_SearchGame<T>(MetadataProvider metadataProvider, string platformId, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T> result = _GetMetadataProxy_SearchGame<T>(TypeName, metadataProvider, platformId, search);

                return result.Result;
            }

            return default;
        }

        /// <summary>
        /// Search the Hasheous Metadata Proxy for game
        /// </summary>
        /// <typeparam name="T">
        /// The type to load the metadata into
        /// </typeparam>
        /// <param name="TypeName">
        /// The name of the type of metadata to load
        /// </param>
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="platformId">
        /// The ID of the platform to search within
        /// </param>
        /// <param name="search">
        /// The search string to use
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public T? GetMetadataProxy_SearchGame<T>(string TypeName, MetadataProvider metadataProvider, string platformId, string search)
        {
            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T> result = _GetMetadataProxy_SearchGame<T>(TypeName, metadataProvider, platformId, search);

                return result.Result;
            }

            return default;
        }

        private async Task<T> _GetMetadataProxy_SearchGame<T>(string TypeName, MetadataProvider metadataProvider, string platformId, string search)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/Search/Platform/{platformId}/{TypeName}?SearchString={search}");

            return result;
        }

        public enum MetadataProvider
        {
            IGDB
        }
    }
}