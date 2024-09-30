using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class AlternativeName : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("comment")]
    [JsonProperty("comment")]
    public string Comment { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public object Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }
  }
}

namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class AlternativeName : global::IGDB.Models.AlternativeName
  {
    public IdentityOrValue Game { get; set; }
  }
}