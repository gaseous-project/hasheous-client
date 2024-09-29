using System;
using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Game : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("age_ratings")]
    [JsonProperty("age_ratings")]
    public List<object> AgeRatings { get; set; }

    [JsonPropertyName("aggregated_rating")]
    [JsonProperty("aggregated_rating")]
    public double? AggregatedRating { get; set; }

    [JsonPropertyName("aggregated_rating_count")]
    [JsonProperty("aggregated_rating_count")]
    public int? AggregatedRatingCount { get; set; }

    [JsonPropertyName("alternative_names")]
    [JsonProperty("alternative_names")]
    public List<object> AlternativeNames { get; set; }

    [JsonPropertyName("artworks")]
    [JsonProperty("artworks")]
    public List<object> Artworks { get; set; }

    [JsonPropertyName("bundles")]
    [JsonProperty("bundles")]
    public List<object> Bundles { get; set; }

    [JsonPropertyName("category")]
    [JsonProperty("category")]
    public Category? Category { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("collections")]
    [JsonProperty("collections")]
    public List<object> Collections { get; set; }

    [JsonPropertyName("cover")]
    [JsonProperty("cover")]
    public object Cover { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("dlcs")]
    [JsonProperty("dlcs")]
    public List<object> Dlcs { get; set; }

    [JsonPropertyName("expanded_games")]
    [JsonProperty("expanded_games")]
    public List<object> ExpandedGames { get; set; }

    [JsonPropertyName("expansions")]
    [JsonProperty("expansions")]
    public List<object> Expansions { get; set; }

    [JsonPropertyName("external_games")]
    [JsonProperty("external_games")]
    public List<object> ExternalGames { get; set; }

    [JsonPropertyName("first_release_date")]
    [JsonProperty("first_release_date")]
    public DateTimeOffset? FirstReleaseDate { get; set; }

    [JsonPropertyName("forks")]
    [JsonProperty("forks")]
    public List<object> Forks { get; set; }

    [JsonPropertyName("franchise")]
    [JsonProperty("franchise")]
    public object Franchise { get; set; }

    [JsonPropertyName("franchises")]
    [JsonProperty("franchises")]
    public List<object> Franchises { get; set; }

    [JsonPropertyName("game_engines")]
    [JsonProperty("game_engines")]
    public List<object> GameEngines { get; set; }

    [JsonPropertyName("game_localizations")]
    [JsonProperty("game_localizations")]
    public List<object> GameLocalizations { get; set; }

    [JsonPropertyName("game_modes")]
    [JsonProperty("game_modes")]
    public List<object> GameModes { get; set; }

    [JsonPropertyName("genres")]
    [JsonProperty("genres")]
    public List<object> Genres { get; set; }

    [JsonPropertyName("hypes")]
    [JsonProperty("hypes")]
    public int? Hypes { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("involved_companies")]
    [JsonProperty("involved_companies")]
    public List<object> InvolvedCompanies { get; set; }

    [JsonPropertyName("keywords")]
    [JsonProperty("keywords")]
    public List<object> Keywords { get; set; }

    [JsonPropertyName("language_supports")]
    [JsonProperty("language_supports")]
    public List<object> LanguageSupports { get; set; }

    [JsonPropertyName("multiplayer_modes")]
    [JsonProperty("multiplayer_modes")]
    public List<object> MultiplayerModes { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("parent_game")]
    [JsonProperty("parent_game")]
    public object ParentGame { get; set; }

    [JsonPropertyName("platforms")]
    [JsonProperty("platforms")]
    public List<object> Platforms { get; set; }

    [JsonPropertyName("player_perspectives")]
    [JsonProperty("player_perspectives")]
    public List<object> PlayerPerspectives { get; set; }

    [JsonPropertyName("ports")]
    [JsonProperty("ports")]
    public List<object> Ports { get; set; }

    [JsonPropertyName("rating")]
    [JsonProperty("rating")]
    public double? Rating { get; set; }

    [JsonPropertyName("rating_count")]
    [JsonProperty("rating_count")]
    public int? RatingCount { get; set; }

    [JsonPropertyName("release_dates")]
    [JsonProperty("release_dates")]
    public List<object> ReleaseDates { get; set; }

    [JsonPropertyName("remakes")]
    [JsonProperty("remakes")]
    public List<object> Remakes { get; set; }

    [JsonPropertyName("remasters")]
    [JsonProperty("remasters")]
    public List<object> Remasters { get; set; }

    [JsonPropertyName("screenshots")]
    [JsonProperty("screenshots")]
    public List<object> Screenshots { get; set; }

    [JsonPropertyName("similar_games")]
    [JsonProperty("similar_games")]
    public List<object> SimilarGames { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("standalone_expansions")]
    [JsonProperty("standalone_expansions")]
    public List<object> StandaloneExpansions { get; set; }

    [JsonPropertyName("status")]
    [JsonProperty("status")]
    public GameStatus? Status { get; set; }

    [JsonPropertyName("storyline")]
    [JsonProperty("storyline")]
    public string Storyline { get; set; }

    [JsonPropertyName("summary")]
    [JsonProperty("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("tags")]
    [JsonProperty("tags")]
    public int[] Tags { get; set; }

    [JsonPropertyName("themes")]
    [JsonProperty("themes")]
    public List<object> Themes { get; set; }

    [JsonPropertyName("total_rating")]
    [JsonProperty("total_rating")]
    public double? TotalRating { get; set; }

    [JsonPropertyName("total_rating_count")]
    [JsonProperty("total_rating_count")]
    public int? TotalRatingCount { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonPropertyName("version_parent")]
    [JsonProperty("version_parent")]
    public object VersionParent { get; set; }

    [JsonPropertyName("version_title")]
    [JsonProperty("version_title")]
    public string VersionTitle { get; set; }

    [JsonPropertyName("videos")]
    [JsonProperty("videos")]
    public List<object> Videos { get; set; }

    [JsonPropertyName("websites")]
    [JsonProperty("websites")]
    public List<object> Websites { get; set; }
  }

  public enum Category
  {
    MainGame = 0,
    DlcAddon = 1,
    Expansion = 2,
    Bundle = 3,
    StandaloneExpansion = 4,
    Mod = 5,
    Episode = 6,
    Season = 7,
    Remake = 8,
    Remaster = 9,
    ExpandedGame = 10,
    Port = 11,
    Fork = 12,
    Pack = 13,
    Update = 14
  }

  public enum GameStatus
  {
    Released = 0,
    Alpha = 2,
    Beta = 3,
    EarlyAccess = 4,
    Offline = 5,
    Cancelled = 6,
    Rumored = 7,
    Delisted = 8
  }
}

namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Game : global::IGDB.Models.Game
  {
    public IdentitiesOrValues AgeRatings { get; set; }
    public IdentitiesOrValues AlternativeNames { get; set; }
    public IdentitiesOrValues Artworks { get; set; }
    public IdentitiesOrValues Bundles { get; set; }
    public IdentitiesOrValues Collections { get; set; }
    public IdentityOrValue Cover { get; set; }
    public IdentitiesOrValues Dlcs { get; set; }
    public IdentitiesOrValues ExpandedGames { get; set; }
    public IdentitiesOrValues Expansions { get; set; }
    public IdentitiesOrValues ExternalGames { get; set; }
    public IdentitiesOrValues Forks { get; set; }
    public IdentityOrValue Franchise { get; set; }
    public IdentitiesOrValues Franchises { get; set; }
    public IdentitiesOrValues GameEngines { get; set; }
    public IdentitiesOrValues GameLocalizations { get; set; }
    public IdentitiesOrValues GameModes { get; set; }
    public IdentitiesOrValues Genres { get; set; }
    public IdentitiesOrValues InvolvedCompanies { get; set; }
    public IdentitiesOrValues Keywords { get; set; }
    public IdentitiesOrValues LanguageSupports { get; set; }
    public IdentitiesOrValues MultiplayerModes { get; set; }
    public IdentityOrValue ParentGame { get; set; }
    public IdentitiesOrValues Platforms { get; set; }
    public IdentitiesOrValues PlayerPerspectives { get; set; }
    public IdentitiesOrValues Ports { get; set; }
    public IdentitiesOrValues ReleaseDates { get; set; }
    public IdentitiesOrValues Remakes { get; set; }
    public IdentitiesOrValues Remasters { get; set; }
    public IdentitiesOrValues Screenshots { get; set; }
    public IdentitiesOrValues SimilarGames { get; set; }
    public IdentitiesOrValues StandaloneExpansions { get; set; }
    public GameStatus? Status { get; set; }
    public IdentitiesOrValues Themes { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public IdentityOrValue VersionParent { get; set; }
    public IdentitiesOrValues Videos { get; set; }
    public IdentitiesOrValues Websites { get; set; }
  }
}