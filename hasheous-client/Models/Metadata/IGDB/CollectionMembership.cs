using System;
using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class CollectionMembership : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("collection")]
    [JsonProperty("collection")]
    public long Collection { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    [JsonProperty("type")]
    public long Type { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class CollectionMembership : global::IGDB.Models.CollectionMembership
  {
    public IdentityOrValue Collection { get; set; }
    public IdentityOrValue Game { get; set; }
    public IdentityOrValue Type { get; set; }
  }
}