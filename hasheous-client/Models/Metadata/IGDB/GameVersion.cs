using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class GameVersion : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("features")]
    [JsonProperty("features")]
    public List<object> Features { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public object Game { get; set; }

    [JsonPropertyName("games")]
    [JsonProperty("games")]
    public List<object> Games { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class GameVersion : global::IGDB.Models.GameVersion
  {
    public IdentitiesOrValues Features { get; set; }
    public IdentityOrValue Game { get; set; }
    public IdentitiesOrValues Games { get; set; }
  }
}