using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class GameVersionFeatureValue : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("game_feature")]
    [JsonProperty("game_feature")]
    public long GameFeature { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("included_feature")]
    [JsonProperty("included_feature")]
    public IncludedFeature? IncludedFeature { get; set; }

    [JsonPropertyName("note")]
    [JsonProperty("note")]
    public string Note { get; set; }
  }

  public enum IncludedFeature
  {
    NotIncluded = 0,
    Included = 1,
    PreOrderOnly = 2
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class GameVersionFeatureValue : global::IGDB.Models.GameVersionFeatureValue
  {
    public IdentityOrValue Game { get; set; }
    public IdentityOrValue GameFeature { get; set; }
  }
}