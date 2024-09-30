using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class InvolvedCompany : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("company")]
    [JsonProperty("company")]
    public object Company { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("developer")]
    [JsonProperty("developer")]
    public bool? Developer { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public object Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("porting")]
    [JsonProperty("porting")]
    public bool? Porting { get; set; }

    [JsonPropertyName("publisher")]
    [JsonProperty("publisher")]
    public bool? Publisher { get; set; }

    [JsonPropertyName("supporting")]
    [JsonProperty("supporting")]
    public bool? Supporting { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class InvolvedCompany : global::IGDB.Models.InvolvedCompany
  {
    public IdentityOrValue Company { get; set; }
    public IdentityOrValue Game { get; set; }
  }
}