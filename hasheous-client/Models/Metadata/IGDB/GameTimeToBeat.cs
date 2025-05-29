using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
    public class GameTimeToBeat : ITools, IIdentifier, IHasChecksum
    {
        [JsonPropertyName("checksum")]
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonPropertyName("created_at")]
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonPropertyName("game_id")]
        [JsonProperty("game_id")]
        public int GameId { get; set; }

        [JsonPropertyName("hastily")]
        [JsonProperty("hastily")]
        public int? Hastily { get; set; }

        [JsonPropertyName("normally")]
        [JsonProperty("normally")]
        public int? Normally { get; set; }

        [JsonPropertyName("completely")]
        [JsonProperty("completely")]
        public int? Completely { get; set; }
    }
}