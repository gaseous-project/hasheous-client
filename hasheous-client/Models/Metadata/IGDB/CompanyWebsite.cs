using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class CompanyWebsite : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("type")]
    [JsonProperty("type")]
    public long? Type { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("trusted")]
    [JsonProperty("trusted")]
    public bool? Trusted { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }
}