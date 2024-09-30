using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class PlatformVersionCompany : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("comment")]
    [JsonProperty("comment")]
    public string Comment { get; set; }

    [JsonPropertyName("company")]
    [JsonProperty("company")]
    public object Company { get; set; }

    [JsonPropertyName("developer")]
    [JsonProperty("developer")]
    public bool? Developer { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("manufacturer")]
    [JsonProperty("manufacturer")]
    public bool? Manufacturer { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class PlatformVersionCompany : global::IGDB.Models.PlatformVersionCompany
  {
    public IdentityOrValue Company { get; set; }
  }
}