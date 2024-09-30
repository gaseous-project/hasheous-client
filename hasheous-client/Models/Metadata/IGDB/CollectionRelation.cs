using System;
using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class CollectionRelation : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("child_collection")]
    [JsonProperty("child_collection")]
    public object ChildCollection { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("parent_collection")]
    [JsonProperty("parent_collection")]
    public object ParentCollection { get; set; }

    [JsonPropertyName("type")]
    [JsonProperty("type")]
    public object Type { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class CollectionRelation : global::IGDB.Models.CollectionRelation
  {
    public IdentityOrValue ChildCollection { get; set; }
    public IdentityOrValue ParentCollection { get; set; }
    public IdentityOrValue Type { get; set; }
  }
}