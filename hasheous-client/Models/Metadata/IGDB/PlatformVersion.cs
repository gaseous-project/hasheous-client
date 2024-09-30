using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class PlatformVersion : ITools, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("companies")]
    [JsonProperty("companies")]
    public List<object> Companies { get; set; }

    [JsonPropertyName("connectivity")]
    [JsonProperty("connectivity")]
    public string Connectivity { get; set; }

    [JsonPropertyName("cpu")]
    [JsonProperty("cpu")]
    public string CPU { get; set; }

    [JsonPropertyName("graphics")]
    [JsonProperty("graphics")]
    public string Graphics { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("main_manufacturer")]
    [JsonProperty("main_manufacturer")]
    public object MainManufacturer { get; set; }

    [JsonPropertyName("media")]
    [JsonProperty("media")]
    public string Media { get; set; }

    [JsonPropertyName("memory")]
    [JsonProperty("memory")]
    public string Memory { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("os")]
    [JsonProperty("os")]
    public string OS { get; set; }

    [JsonPropertyName("output")]
    [JsonProperty("output")]
    public string Output { get; set; }

    [JsonPropertyName("platform_logo")]
    [JsonProperty("platform_logo")]
    public object PlatformLogo { get; set; }

    [JsonPropertyName("platform_version_release_dates")]
    [JsonProperty("platform_version_release_dates")]
    public List<object> PlatformVersionReleaseDates { get; set; }

    [JsonPropertyName("resolutions")]
    [JsonProperty("resolutions")]
    public string Resolutions { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("sound")]
    [JsonProperty("sound")]
    public string Sound { get; set; }

    [JsonPropertyName("storage")]
    [JsonProperty("storage")]
    public string Storage { get; set; }

    [JsonPropertyName("summary")]
    [JsonProperty("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class PlatformVersion : global::IGDB.Models.PlatformVersion
  {
    public IdentitiesOrValues Companies { get; set; }
    public IdentitiesOrValues MainManufacturer { get; set; }
    public IdentityOrValue PlatformLogo { get; set; }
    public IdentitiesOrValues PlatformVersionReleaseDates { get; set; }
  }
}