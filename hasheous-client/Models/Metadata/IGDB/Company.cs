using System;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class Company : ITools, ITimestamps, IIdentifier, IHasChecksum
  {
    [JsonPropertyName("change_date")]
    [JsonProperty("change_date")]
    public DateTimeOffset? ChangeDate { get; set; }

    [JsonPropertyName("change_date_format")]
    [JsonProperty("change_date_format")]
    public long ChangeDateFormat { get; set; }

    [JsonPropertyName("changed_company_id")]
    [JsonProperty("changed_company_id")]
    public long ChangedCompanyId { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    /// <summary>
    /// ISO 3166-1 country code
    /// </summary>
    [JsonPropertyName("country")]
    [JsonProperty("country")]
    public int? Country { get; set; }

    [JsonPropertyName("created_at")]
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }


    [JsonPropertyName("developed")]
    [JsonProperty("developed")]
    public List<long> Developed { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonPropertyName("logo")]
    [JsonProperty("logo")]
    public long Logo { get; set; }

    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonPropertyName("parent")]
    [JsonProperty("parent")]
    public long Parent { get; set; }

    [JsonPropertyName("published")]
    [JsonProperty("published")]
    public List<long> Published { get; set; }

    [JsonPropertyName("slug")]
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("start_date")]
    [JsonProperty("start_date")]
    public DateTimeOffset? StartDate { get; set; }

    [JsonPropertyName("start_date_format")]
    [JsonProperty("start_date_format")]
    public long? StartDateFormat { get; set; }

    [JsonPropertyName("status")]
    [JsonProperty("status")]
    public long Status { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonPropertyName("websites")]
    [JsonProperty("websites")]
    public List<long> Websites { get; set; }

  }
}


namespace HasheousClient.Models.Metadata.IGDB.Override
{
  public class Company : global::IGDB.Models.Company
  {
    public IdentityOrValue ChangedCompanyId { get; set; }
    public IdentitiesOrValues Developed { get; set; }
    public IdentityOrValue Logo { get; set; }
    public IdentityOrValue Parent { get; set; }
    public IdentitiesOrValues Published { get; set; }
    public IdentitiesOrValues Websites { get; set; }
  }
}