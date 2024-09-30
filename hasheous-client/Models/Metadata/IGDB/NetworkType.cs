using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class NetworkType : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("event_networks")]
    [JsonProperty("event_networks")]
    public List<object> EventNetworks { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class NetworkType : global::IGDB.Models.NetworkType
  {
    public IdentitiesOrValues EventNetworks { get; set; }
  }
}