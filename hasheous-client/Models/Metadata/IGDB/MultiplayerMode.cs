using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class MultiplayerMode : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("campaigncoop")]
    [JsonProperty("campaigncoop")]
    public bool? CampaignCoop { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("dropin")]
    [JsonProperty("dropin")]
    public bool? DropIn { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public long Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("lancoop")]
    [JsonProperty("lancoop")]
    public bool? LanCoop { get; set; }

    [JsonPropertyName("offlinecoop")]
    [JsonProperty("offlinecoop")]
    public bool? OfflineCoop { get; set; }

    [JsonPropertyName("offlinecoopmax")]
    [JsonProperty("offlinecoopmax")]
    public int? OfflineCoopMax { get; set; }

    [JsonPropertyName("offlinemax")]
    [JsonProperty("offlinemax")]
    public int? OfflineMax { get; set; }

    [JsonPropertyName("onlinecoop")]
    [JsonProperty("onlinecoop")]
    public bool? OnlineCoop { get; set; }

    [JsonPropertyName("onlinecoopmax")]
    [JsonProperty("onlinecoopmax")]
    public int? OnlineCoopMax { get; set; }

    [JsonPropertyName("onlinemax")]
    [JsonProperty("onlinemax")]
    public int? OnlineMax { get; set; }

    [JsonPropertyName("platform")]
    [JsonProperty("platform")]
    public long Platform { get; set; }

    [JsonPropertyName("splitscreen")]
    [JsonProperty("splitscreen")]
    public bool? SplitScreen { get; set; }

    [JsonPropertyName("splitscreenonline")]
    [JsonProperty("splitscreenonline")]
    public bool? SplitScreenOnline { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class MultiplayerMode : global::IGDB.Models.MultiplayerMode
  {
    public IdentityOrValue Game { get; set; }
    public IdentityOrValue Platform { get; set; }
  }
}