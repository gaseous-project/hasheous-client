using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Character : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("akas")]
    [JsonProperty("akas")]
    public string[] Akas { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("country_name")]
    [JsonProperty("country_name")]
    public string CountryName { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonPropertyName("games")]
    [JsonProperty("games")]
    public List<object> Games { get; set; }

    [JsonPropertyName("gender")]
    [JsonProperty("gender")]
    public Gender? Gender { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("mug_shot")]
    [JsonProperty("mug_shot")]
    public object MugShot { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("species")]
    [JsonProperty("species")]
    public Species? Species { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }

  public enum Gender
  {
    Male = 1,
    Female = 2,
    Other = 3
  }

  public enum Species
  {
    Human = 1,
    Alien = 2,
    Animal = 3,
    Android = 4,
    Unknown = 5
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Character : global::IGDB.Models.Character
  {
    public IdentitiesOrValues Games { get; set; }
    public IdentityOrValue MugShot { get; set; }
  }
}