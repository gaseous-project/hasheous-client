using System;
using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Collection : ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("as_child_relations")]
    [JsonProperty("as_child_relations")]
    public List<object> AsChildRelations { get; set; }

    [JsonPropertyName("as_parent_relations")]
    [JsonProperty("as_parent_relations")]
    public List<object> AsParentRelations { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("games")]
    [JsonProperty("games")]
    public List<object> Games { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("type")]
    [JsonProperty("type")]
    public object Type { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Collection : global::IGDB.Models.Collection
  {
    public IdentitiesOrValues AsChildRelations { get; set; }
    public IdentitiesOrValues AsParentRelations { get; set; }
    public IdentitiesOrValues Games { get; set; }
    public IdentityOrValue Type { get; set; }
  }
}