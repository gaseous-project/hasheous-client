using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class Genres : BaseApiResponse
    {
        public DataItem data { get; set; }

        public class DataItem
        {
            public int count { get; set; }
            public List<Genre> genres { get; set; }
        }
    }
}