using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
    public class ExternalGameSource : ITools, ITimestamps, IIdentifier, IHasChecksum
    {
        [JsonPropertyName("checksum")]
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonPropertyName("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonPropertyName("created_at")]
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}