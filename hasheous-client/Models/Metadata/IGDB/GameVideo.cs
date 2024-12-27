using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class GameVideo : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("video_id")]
    [JsonProperty("video_id")]
    public string VideoId { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class GameVideo : global::IGDB.Models.GameVideo
  {
    public IdentityOrValue Game { get; set; }
  }
}