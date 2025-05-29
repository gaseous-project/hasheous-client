using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
    public class AgeRatingOrganization : ITools, IIdentifier, IHasChecksum
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
    }
}