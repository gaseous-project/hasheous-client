using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
    public class PopularityType : ITools, IHasChecksum
    {
        [JsonPropertyName("checksum")]
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonPropertyName("external_popularity_source")]
        [JsonProperty("external_popularity_source")]
        public long? ExternalPopularitySource { get; set; }

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