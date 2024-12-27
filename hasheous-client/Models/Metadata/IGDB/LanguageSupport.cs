using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class LanguageSupport : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("language")]
    [JsonProperty("language")]
    public long Language { get; set; }

    [JsonPropertyName("language_support_type")]
    [JsonProperty("language_support_type")]
    public long LanguageSupportType { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class LanguageSupport : global::IGDB.Models.LanguageSupport
  {
    public IdentityOrValue Game { get; set; }
    public IdentityOrValue Language { get; set; }
    public IdentityOrValue LanguageSupportType { get; set; }
  }
}