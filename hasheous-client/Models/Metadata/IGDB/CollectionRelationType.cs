using System;
using Newtonsoft.Json;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class CollectionRelationType : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("allowed_child_type")]
    [JsonProperty("allowed_child_type")]
    public object AllowedChildType { get; set; }

    [JsonPropertyName("allowed_parent_type")]
    [JsonProperty("allowed_parent_type")]
    public object AllowedParentType { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class CollectionRelationType : global::IGDB.Models.CollectionRelationType
  {
    public IdentityOrValue AllowedChildType { get; set; }
    public IdentityOrValue AllowedParentType { get; set; }
  }
}