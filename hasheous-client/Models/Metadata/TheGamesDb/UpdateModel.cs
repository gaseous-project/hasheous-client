using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.TheGamesDb
{
    public class UpdateModel
    {
        public int edit_id { get; set; }
        public int game_id { get; set; }
        public string timestamp { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }
}