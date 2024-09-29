using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class CompanyWebsite : IIdentifier, IHasChecksum
  {
    [JsonPropertyName("category")]
    [JsonProperty("category")]
    public CompanyWebsiteCategory? Category { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("trusted")]
    [JsonProperty("trusted")]
    public bool? Trusted { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }

  public enum CompanyWebsiteCategory
  {
    Official = 1,
    Wikia = 2,
    Wikipedia = 3,
    Facebook = 4,
    Twitter = 5,
    Twitch = 6,
    Instagram = 8,
    YouTube = 9,
    iPhone = 10,
    iPad = 11,
    Android = 12,
    Steam = 13,
    Reddit = 14,
    Itch = 15,
    EpicGames = 16,
    GOG = 17,
    Discord = 18
  }
}