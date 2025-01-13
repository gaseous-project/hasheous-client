using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class GamesByGameID_v1 : PaginatedApiResponse
    {
        public DataItem data { get; set; }
        public IncludeItem include { get; set; }

        public class DataItem
        {
            public int count { get; set; }
            public List<Game> games { get; set; }
        }

        public class IncludeItem
        {
            public BoxartDataItem boxart { get; set; }
            public List<PlatformSkinny> platform { get; set; }

            public class BoxartDataItem
            {
                public ImageBaseUrlMeta base_url { get; set; }
                public List<GameImage> data { get; set; }
            }
        }
    }
}