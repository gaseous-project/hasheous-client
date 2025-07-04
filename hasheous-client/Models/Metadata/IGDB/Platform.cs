using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Platform : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("abbreviation")]
    [JsonProperty("abbreviation")]
    public string Abbreviation { get; set; }

    [JsonPropertyName("alternative_name")]
    [JsonProperty("alternative_name")]
    public string AlternativeName { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("generation")]
    [JsonProperty("generation")]
    public int? Generation { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("platform_family")]
    [JsonProperty("platform_family")]
    public long PlatformFamily { get; set; }

    [JsonPropertyName("platform_logo")]
    [JsonProperty("platform_logo")]
    public long PlatformLogo { get; set; }

    [JsonPropertyName("platform_type")]
    [JsonProperty("platform_type")]
    public long PlatformType { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("summary")]
    [JsonProperty("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonPropertyName("versions")]
    [JsonProperty("versions")]
    public List<long> Versions { get; set; }

    [JsonPropertyName("websites")]
    [JsonProperty("websites")]
    public List<long> Websites { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Platform : global::IGDB.Models.Platform
  {
    public IdentityOrValue PlatformFamily { get; set; }
    public IdentityOrValue PlatformLogo { get; set; }
    public IdentitiesOrValues Versions { get; set; }
    public IdentitiesOrValues Websites { get; set; }
  }
}