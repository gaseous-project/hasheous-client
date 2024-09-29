using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Event : ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonPropertyName("end_time")]
    [JsonProperty("end_time")]
    public DateTimeOffset? EndTime { get; set; }

    [JsonPropertyName("event_logo")]
    [JsonProperty("event_logo")]
    public object EventLogo { get; set; }

    [JsonPropertyName("event_networks")]
    [JsonProperty("event_networks")]
    public List<object> EventNetwork { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("games")]
    [JsonProperty("games")]
    public List<object> Games { get; set; }

    [JsonPropertyName("live_stream_url")]
    [JsonProperty("live_stream_url")]
    public string LiveStreamUrl { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("start_time")]
    [JsonProperty("start_time")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("time_zone")]
    [JsonProperty("time_zone")]
    public string TimeZone { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("videos")]
    [JsonProperty("videos")]
    public List<object> Videos { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Event : global::IGDB.Models.Event
  {
    public IdentityOrValue EventLogo { get; set; }
    public IdentitiesOrValues EventNetwork { get; set; }
    public IdentitiesOrValues Games { get; set; }
    public IdentitiesOrValues Videos { get; set; }
  }
}