using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class ExternalGame : ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("category")]
    [JsonProperty("category")]
    public ExternalCategory? Category { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("countries")]
    [JsonProperty("countries")]
    public double[] Countries { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("game")]
    [JsonProperty("game")]
    public object Game { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("media")]
    [JsonProperty("media")]
    public ExternalGameMedia? Media { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("platform")]
    [JsonProperty("platform")]
    public object Platform { get; set; }

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

  public enum ExternalGameMedia
  {
    Digital = 1,
    Physical = 2
  }

  public enum ExternalCategory
  {
    Steam = 1,
    GOG = 5,
    YouTube = 10,
    Microsoft = 11,
    Apple = 13,
    Twitch = 14,
    Android = 15,
    AmazonAsin = 20,
    AmazonLuna = 22,
    AmazonAdg = 23,
    EpicGameStore = 26,
    Oculus = 28,
    Utomik = 29,
    ItchIO = 30,
    XboxMarketplace = 31,
    Kartridge = 32,
    PlaystationStoreUS = 36,
    FocusEntertainment = 37,
    XboxGamePassUltimateCloud = 54,
    Gamejolt = 55
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