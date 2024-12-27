using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Franchise : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("games")]
    [JsonProperty("games")]
    public List<long> Games { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Franchise : global::IGDB.Models.Franchise
  {
    public IdentitiesOrValues Games { get; set; }
  }
}