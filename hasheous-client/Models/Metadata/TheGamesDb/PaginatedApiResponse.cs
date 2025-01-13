using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class PaginatedApiResponse : BaseApiResponse
    {
        public class PagesItem
        {
            public string previous { get; set; }
            public string current { get; set; }
            public string next { get; set; }
        }
    }
}