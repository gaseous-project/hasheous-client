using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class Platform
    {
        public int id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string icon { get; set; }
        public string console { get; set; }
        public string controller { get; set; }
        public string developer { get; set; }
        public string overview { get; set; }
    }
}