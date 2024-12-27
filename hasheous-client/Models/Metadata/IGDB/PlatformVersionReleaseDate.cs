using System;
using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class PlatformVersionReleaseDate : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("category")]
    [JsonProperty("category")]
    public ReleaseDateCategory? Category { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("date")]
    [JsonProperty("date")]
    public DateTimeOffset? Date { get; set; }

    [JsonPropertyName("human")]
    [JsonProperty("human")]
    public string Human { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("m")]
    [JsonProperty("m")]
    public int? Month { get; set; }

    [JsonPropertyName("platform_version")]
    [JsonProperty("platform_version")]
    public long PlatformVersion { get; set; }

    [JsonPropertyName("region")]
    [JsonProperty("region")]
    public ReleaseDateRegion? Region { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("y")]
    [JsonProperty("y")]
    public int? Year { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class PlatformVersionReleaseDate : global::IGDB.Models.PlatformVersionReleaseDate
  {
    public IdentityOrValue PlatformVersion { get; set; }
  }
}