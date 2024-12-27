using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class GameEngine : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("companies")]
    [JsonProperty("companies")]
    public List<long> Companies { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonPropertyName("logo")]
    [JsonProperty("logo")]
    public long Logo { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("platforms")]
    [JsonProperty("platforms")]
    public List<long> Platforms { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

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
  public class GameEngine : global::IGDB.Models.GameEngine
  {
    public IdentitiesOrValues Companies { get; set; }
    public IdentityOrValue GameEngineLogo { get; set; }
    public IdentitiesOrValues Platforms { get; set; }
  }
}