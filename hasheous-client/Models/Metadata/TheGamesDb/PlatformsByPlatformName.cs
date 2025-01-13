using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class PlatformsByPlatformName : BaseApiResponse
    {
        public DataItem data { get; set; }

        public class DataItem
        {
            public int count { get; set; }
            public List<Platform> platforms { get; set; }
        }
    }
}