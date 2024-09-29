using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class EventLogo : ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("alpha_channel")]
    [JsonProperty("alpha_channel")]
    public bool? AlphaChannel { get; set; }

    [JsonPropertyName("animated")]
    [JsonProperty("animated")]
    public bool? Animated { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("event")]
    [JsonProperty("event")]
    public object Event { get; set; }

    [JsonPropertyName("height")]
    [JsonProperty("height")]
    public int? Height { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("image_id")]
    [JsonProperty("image_id")]
    public string ImageId { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonPropertyName("width")]
    [JsonProperty("width")]
    public int? Width { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class EventLogo : global::IGDB.Models.EventLogo
  {
    public IdentityOrValue Event { get; set; }
  }
}