using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class PlatformImage
    {
        public int id { get; set; }
        public string filename { get; set; }
        public string type { get; set; }
    }
}