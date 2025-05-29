using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
    public class PopularityPrimitive : ITools, IIdentifier, ITimestamps
    {
        [JsonPropertyName("calculated_at")]
        [JsonProperty("calculated_at")]
        public DateTimeOffset CalculatedAt { get; set; }

        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonPropertyName("game_id")]
        [JsonProperty("game_id")]
        public long? GameId { get; set; }

        [JsonPropertyName("external_popularity_source")]
        [JsonProperty("external_popularity_source")]
        public long ExternalPopularitySource { get; set; }

        [JsonPropertyName("popularity_type")]
        [JsonProperty("popularity_type")]
        public long PopularityType { get; set; }

        [JsonPropertyName("value")]
        [JsonProperty("value")]
        public decimal? Value { get; set; }

        [JsonPropertyName("created_at")]
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}