using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
    public class Artwork : ITools, IIdentifier, IHasChecksum
    {
        [JsonPropertyName("alpha_channel")]
        [JsonProperty("alpha_channel")]
        public bool? AlphaChannel { get; set; }

        [JsonPropertyName("animated")]
        [JsonProperty("animated")]
        public bool? Animated { get; set; }

        [JsonPropertyName("checksum")]
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonPropertyName("game")]
        [JsonProperty("game")]
        public object Game { get; set; }

        [JsonPropertyName("height")]
        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonPropertyName("image_id")]
        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        [JsonPropertyName("url")]
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
    public class Artwork : global::IGDB.Models.Artwork
    {
        public IdentityOrValue Game { get; set; }
    }
}