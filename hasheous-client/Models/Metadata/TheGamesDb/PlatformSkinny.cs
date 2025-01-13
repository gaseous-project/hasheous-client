using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class PlatformSkinny
    {
        public int id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
    }
}