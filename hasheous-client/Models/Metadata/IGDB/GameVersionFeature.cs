using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class GameVersionFeature : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("category")]
    [JsonProperty("category")]
    public GameVersionFeatureCategory Category { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("position")]
    [JsonProperty("position")]
    public int? Position { get; set; }

    [JsonPropertyName("title")]
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonPropertyName("values")]
    [JsonProperty("values")]
    public List<long> Values { get; set; }
  }

  public enum GameVersionFeatureCategory
  {
    Boolean = 0,
    Description = 1
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class GameVersionFeature : global::IGDB.Models.GameVersionFeature
  {
    public IdentitiesOrValues Values { get; set; }
  }
}