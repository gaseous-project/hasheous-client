using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class ImageBaseUrlMeta
    {
        public string original { get; set; }
        public string small { get; set; }
        public string thumb { get; set; }
        public string cropped_center_thumb { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
    }
}