using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Character : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("akas")]
    [JsonProperty("akas")]
    public List<string> Akas { get; set; }

    [JsonPropertyName("character_gender")]
    [JsonProperty("character_gender")]
    public long CharacterGender { get; set; }

    [JsonPropertyName("character_species")]
    [JsonProperty("character_species")]
    public long CharacterSpecies { get; set; }

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
    public List<long> Games { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("mug_shot")]
    [JsonProperty("mug_shot")]
    public long MugShot { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
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