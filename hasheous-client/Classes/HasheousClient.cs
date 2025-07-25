using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HasheousClient.Models;

namespace HasheousClient
{
    public class Hasheous
    {
        private const string TheGamesDbSlugNotSupportedMessage = "TheGamesDb does not support slug lookups";

#pragma warning disable S2325
        // disables warning about methods should be static as these methods may require instance state in the future
        // and we want to remain backwards compatible

        /// <summary>
        /// Retrieve a lookup item from Hasheous
        /// </summary>
        /// <param name="hash">
        /// The hash to lookup
        /// </param>
        /// <returns>
        /// The lookup item
        /// </returns>
        public LookupItemModel RetrieveFromHasheous(HashLookupModel hash, bool returnAllSources)
        {
            Task<LookupItemModel> result = _RetrieveFromHasheousAsync(hash, returnAllSources);

            return result.Result;
        }

        /// <summary>
        /// Retrieve a lookup item from Hasheous
        /// </summary>
        /// <param name="hash">
        /// The hash to lookup
        /// </param>
        /// <returns>
        /// The lookup item
        /// </returns>
        public async Task<LookupItemModel> RetrieveFromHasheousAsync(HashLookupModel hash, bool returnAllSources)
        {
            return await _RetrieveFromHasheousAsync(hash, returnAllSources);
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

        /// <summary>
        /// Fix a match in Hasheous
        /// </summary>
        /// <param name="model">
        /// The model to fix the match
        /// </param>
        /// <returns>
        /// The fixed match model
        /// </returns>
        public async Task<FixMatchModel> FixMatchAsync(FixMatchModel model)
        {
            return await _FixMatchAsync(model);
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

        /// <summary>
        /// Get a list of platforms from Hasheous
        /// </summary>
        /// <returns>
        /// A list of platforms
        /// </returns>
        public async Task<List<DataObjectItem>> GetPlatformsAsync()
        {
            return await _GetPlatformsAsync();
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
        public T GetMetadataProxy<T>(MetadataProvider metadataProvider, long? id)
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
        public T GetMetadataProxy<T>(string TypeName, MetadataProvider metadataProvider, long? id)
        {
            Task<T> result = _GetMetadataProxy<T>(TypeName, metadataProvider, id);

            return result.Result;
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
            switch (metadataProvider)
            {
                case MetadataProvider.TheGamesDb:
                    throw new NotSupportedException(TheGamesDbSlugNotSupportedMessage);
                default:
                    break;
            }

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
            switch (metadataProvider)
            {
                case MetadataProvider.TheGamesDb:
                    throw new NotSupportedException(TheGamesDbSlugNotSupportedMessage);
                default:
                    break;
            }

            Task<T> result = _GetMetadataProxy<T>(TypeName, metadataProvider, slug);

            return result.Result;
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
        public async Task<T> GetMetadataProxyAsync<T>(MetadataProvider metadataProvider, long? id)
        {
            string TypeName = typeof(T).Name;

            return await _GetMetadataProxy<T>(TypeName, metadataProvider, id);
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
        public async Task<T> GetMetadataProxyAsync<T>(string TypeName, MetadataProvider metadataProvider, long? id)
        {
            return await _GetMetadataProxy<T>(TypeName, metadataProvider, id);
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
        public async Task<T> GetMetadataProxyAsync<T>(MetadataProvider metadataProvider, string slug)
        {
            switch (metadataProvider)
            {
                case MetadataProvider.TheGamesDb:
                    throw new NotSupportedException(TheGamesDbSlugNotSupportedMessage);
                default:
                    break;
            }

            string TypeName = typeof(T).Name;

            return await _GetMetadataProxy<T>(TypeName, metadataProvider, slug);
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
        public async Task<T> GetMetadataProxyAsync<T>(string TypeName, MetadataProvider metadataProvider, string slug)
        {
            switch (metadataProvider)
            {
                case MetadataProvider.TheGamesDb:
                    throw new NotSupportedException(TheGamesDbSlugNotSupportedMessage);
                default:
                    break;
            }

            return await _GetMetadataProxy<T>(TypeName, metadataProvider, slug);
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
        public T[]? GetMetadataProxy_SearchPlatform<T>(MetadataProvider metadataProvider, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T[]> result = _GetMetadataProxy_SearchPlatform<T>(TypeName, metadataProvider, search);

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
        public T[]? GetMetadataProxy_SearchPlatform<T>(string TypeName, MetadataProvider metadataProvider, string search)
        {
            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T[]> result = _GetMetadataProxy_SearchPlatform<T>(TypeName, metadataProvider, search);

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
        /// <param name="metadataProvider">
        /// The metadata provider to use
        /// </param>
        /// <param name="search">
        /// The search string to use
        /// </param>
        /// <returns>
        /// The metadata from the provider
        /// </returns>
        public async Task<T[]?> GetMetadataProxy_SearchPlatformAsync<T>(MetadataProvider metadataProvider, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (metadataProvider == MetadataProvider.IGDB)
            {
                return await _GetMetadataProxy_SearchPlatform<T>(TypeName, metadataProvider, search);
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
        public async Task<T[]?> GetMetadataProxy_SearchPlatformAsync<T>(string TypeName, MetadataProvider metadataProvider, string search)
        {
            if (metadataProvider == MetadataProvider.IGDB)
            {
                return await _GetMetadataProxy_SearchPlatform<T>(TypeName, metadataProvider, search);
            }

            return default;
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
        public T[]? GetMetadataProxy_SearchGame<T>(MetadataProvider metadataProvider, string platformId, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T[]> result = _GetMetadataProxy_SearchGame<T>(TypeName, metadataProvider, platformId, search);

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
        public T[]? GetMetadataProxy_SearchGame<T>(string TypeName, MetadataProvider metadataProvider, string platformId, string search)
        {
            if (metadataProvider == MetadataProvider.IGDB)
            {
                Task<T[]> result = _GetMetadataProxy_SearchGame<T>(TypeName, metadataProvider, platformId, search);

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
        public async Task<T[]?> GetMetadataProxy_SearchGameAsync<T>(MetadataProvider metadataProvider, string platformId, string search)
        {
            string TypeName = typeof(T).Name.Replace("[]", "");

            if (metadataProvider == MetadataProvider.IGDB)
            {
                return await _GetMetadataProxy_SearchGame<T>(TypeName, metadataProvider, platformId, search);
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
        public async Task<T[]?> GetMetadataProxy_SearchGameAsync<T>(string TypeName, MetadataProvider metadataProvider, string platformId, string search)
        {
            if (metadataProvider == MetadataProvider.IGDB)
            {
                return await _GetMetadataProxy_SearchGame<T>(TypeName, metadataProvider, platformId, search);
            }

            return default;
        }
#pragma warning restore S2325

        #region Private Methods
        private static async Task<FixMatchModel> _FixMatchAsync(FixMatchModel model)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Post<FixMatchModel>($"/api/v1/Submissions/FixMatch", model);

            return result;
        }

        private static async Task<LookupItemModel> _RetrieveFromHasheousAsync(HashLookupModel hashLookup, bool returnAllSources)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Post<LookupItemModel>($"/api/v1/Lookup/ByHash?returnAllSources=" + returnAllSources.ToString(), hashLookup);

            return result;
        }

        private static async Task<List<DataObjectItem>> _GetPlatformsAsync()
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

        private static async Task<T> _GetMetadataProxy<T>(string TypeName, MetadataProvider metadataProvider, long? id)
        {
            string endpointName = TypeName;
            string queryString = "";
            bool lowerCaseId = false;

            // if the metadataProvider is IGDB, just pass it through
            // if the metadataProvider is TheGamesDB, we need to change the endpoint name
            switch (metadataProvider)
            {
                case MetadataProvider.TheGamesDb:
                    lowerCaseId = true;
                    switch (TypeName)
                    {
                        case "Game":
                        case "GamesByGameID":
                            endpointName = "Games/ByGameID";
                            queryString = $"&fields={Uri.EscapeDataString("players,publishers,genres,overview,last_updated,rating,platform,coop,youtube,os,processor,ram,hdd,video,sound,alternates")}&include={Uri.EscapeDataString("boxart,platform")}";
                            if (id == null)
                            {
                                throw new ArgumentNullException(nameof(id), "ID is required for TheGamesDb");
                            }
                            break;

                        case "Platform":
                        case "PlatformsByPlatformID":
                            endpointName = "Platforms/ByPlatformID";
                            queryString = $"&fields={Uri.EscapeDataString("icon,console,controller,developer,manufacturer,media,cpu,memory,graphics,sound,maxcontrollers,display,overview,youtube")}";
                            if (id == null)
                            {
                                throw new ArgumentNullException(nameof(id), "ID is required for TheGamesDb");
                            }
                            break;

                        case "Platforms":
                            endpointName = "Platforms";
                            queryString = $"&fields={Uri.EscapeDataString("icon,console,controller,developer,manufacturer,media,cpu,memory,graphics,sound,maxcontrollers,display,overview,youtube")}";
                            break;

                        case "Genre":
                        case "Genres":
                            endpointName = "Genres";
                            queryString = "";
                            break;

                        case "Publisher":
                        case "Publishers":
                            endpointName = "Publishers";
                            queryString = "";
                            break;

                        case "Developer":
                        case "Developers":
                            endpointName = "Developers";
                            queryString = "";
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            List<string> queryStrings = new List<string>();
            if (id != null)
            {
                if (lowerCaseId)
                {
                    queryStrings.Add($"id={id}{queryString}");
                }
                else
                {
                    queryStrings.Add($"Id={id}{queryString}");
                }
            }

            if (queryString.Length > 0)
            {
                queryStrings.Add(queryString);
            }

            string urlQueryString = string.Join("&", queryStrings);
            if (urlQueryString.Length > 0)
            {
                urlQueryString = "?" + urlQueryString;
            }

            string urlString = $"/api/v1/MetadataProxy/{metadataProvider}/{endpointName}{urlQueryString}";
            Console.WriteLine(urlString);

            var result = await HasheousClient.WebApp.HttpHelper.Get<T>(urlString);

            return result;
        }

        private static async Task<T> _GetMetadataProxy<T>(string TypeName, MetadataProvider metadataProvider, string slug)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Get<T>($"/api/v1/MetadataProxy/{metadataProvider}/{TypeName}?slug={slug}");

            return result;
        }

        private static async Task<T[]> _GetMetadataProxy_SearchPlatform<T>(string TypeName, MetadataProvider metadataProvider, string search)
        {
            if (TypeName == "Platform")
            {
                var result = await HasheousClient.WebApp.HttpHelper.Get<T[]>($"/api/v1/MetadataProxy/{metadataProvider}/Search/{TypeName}?SearchString={search}");

                return result;
            }
            else
            {
                throw new ArgumentException("Invalid type for search", nameof(TypeName));
            }
        }

        private static async Task<T[]> _GetMetadataProxy_SearchGame<T>(string TypeName, MetadataProvider metadataProvider, string platformId, string search)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Get<T[]>($"/api/v1/MetadataProxy/{metadataProvider}/Search/Platform/{platformId}/{TypeName}?SearchString={search}");

            return result;
        }

        public enum MetadataProvider
        {
            None,
            IGDB,
            TheGamesDb,
            RetroAchievements
        }
    }
    #endregion Private Methods
}