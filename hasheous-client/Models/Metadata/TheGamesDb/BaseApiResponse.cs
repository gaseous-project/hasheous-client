using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class BaseApiResponse
    {
        public int code { get; set; }
        public string status { get; set; }
        public int remaining_monthly_allowance { get; set; }
        public int extra_allowance { get; set; }
    }
}