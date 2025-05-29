using System;
using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class ReleaseDate : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("date")]
    [JsonProperty("date")]
    public DateTimeOffset? Date { get; set; }

    [JsonPropertyName("date_format")]
    [JsonProperty("date_format")]
    public long DateFormat { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("human")]
    [JsonProperty("human")]
    public string Human { get; set; }

    [JsonPropertyName("m")]
    [JsonProperty("m")]
    public int? Month { get; set; }

    [JsonPropertyName("platform")]
    [JsonProperty("platform")]
    public long Platform { get; set; }

    [JsonPropertyName("release_region")]
    [JsonProperty("release_region")]
    public long ReleaseRegion { get; set; }

    [JsonPropertyName("status")]
    [JsonProperty("status")]
    public long Status { get; set; }

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
  public class ReleaseDate : global::IGDB.Models.ReleaseDate
  {
    public IdentityOrValue Game { get; set; }
    public IdentityOrValue Platform { get; set; }
    public IdentityOrValue Status { get; set; }
  }
}