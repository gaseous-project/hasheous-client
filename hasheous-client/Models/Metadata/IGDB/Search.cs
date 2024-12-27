using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Search : IHasChecksum
  {
    [JsonPropertyName("alternative_name")]
    [JsonProperty("alternative_name")]
    public string AlternativeName { get; set; }

    [JsonPropertyName("character")]
    [JsonProperty("character")]
    public long Character { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("collection")]
    [JsonProperty("collection")]
    public long Collection { get; set; }

    [JsonPropertyName("company")]
    [JsonProperty("company")]
    public long Company { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("platform")]
    [JsonProperty("platform")]
    public long Platform { get; set; }

    [JsonPropertyName("published_at")]
    [JsonProperty("published_at")]
    public DateTimeOffset? PublishedAt { get; set; }

    [JsonPropertyName("theme")]
    [JsonProperty("theme")]
    public long Theme { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Search : global::IGDB.Models.Search
  {
    public IdentityOrValue Character { get; set; }
    public IdentityOrValue Collection { get; set; }
    public IdentityOrValue Company { get; set; }
    public IdentityOrValue Game { get; set; }
    public IdentityOrValue Platform { get; set; }
    public IdentityOrValue Theme { get; set; }
  }
}