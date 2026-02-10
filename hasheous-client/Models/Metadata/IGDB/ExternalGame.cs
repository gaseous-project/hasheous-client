using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class ExternalGame : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("countries")]
    [JsonProperty("countries")]
    public List<long> Countries { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("external_game_source")]
    [JsonProperty("external_game_source")]
    public long ExternalGameSource { get; set; }

    [JsonPropertyName("game_release_format")]
    [JsonProperty("game_release_format")]
    public long GameReleaseFormat { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("platform")]
    [JsonProperty("platform")]
    public long Platform { get; set; }

    [JsonPropertyName("uid")]
    [JsonProperty("uid")]
    public string Uid { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonPropertyName("year")]
    [JsonProperty("year")]
    public int? Year { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class ExternalGame : global::IGDB.Models.ExternalGame
  {
    public IdentityOrValue Game { get; set; }
    public IdentityOrValue Platform { get; set; }
  }
}