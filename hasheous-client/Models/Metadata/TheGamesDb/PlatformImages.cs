using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class PlatformsImages : PaginatedApiResponse
    {
        public DataItem data { get; set; }

        public class DataItem
        {
            public int count { get; set; }
            public ImageBaseUrlMeta base_url { get; set; }
            public Dictionary<string, List<PlatformImage>> images { get; set; }
        }
    }
}