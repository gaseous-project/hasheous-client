using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class AgeRating : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("organization")]
    [JsonProperty("organization")]
    public long Organization { get; set; }

    [JsonPropertyName("rating_category")]
    [JsonProperty("rating_category")]
    public long RatingCategory { get; set; }

    [JsonPropertyName("rating_content_descriptions")]
    [JsonProperty("rating_content_descriptions")]
    public List<long> RatingContentDescriptions { get; set; }

    [JsonPropertyName("rating_cover_url")]
    [JsonProperty("rating_cover_url")]
    public string RatingCoverUrl { get; set; }

    [JsonPropertyName("synopsis")]
    [JsonProperty("synopsis")]
    public string Synopsis { get; set; }
  }
}

namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class AgeRating : global::IGDB.Models.AgeRating
  {
    public IdentitiesOrValues ContentDescriptions { get; set; }
  }
}