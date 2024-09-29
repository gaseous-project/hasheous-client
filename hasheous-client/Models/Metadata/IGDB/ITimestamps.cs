using System;

namespace HasheousClient.Models.Metadata.IGDB
{
  public interface ITimestamps
  {
    DateTimeOffset? CreatedAt { get; set; }
    DateTimeOffset? UpdatedAt { get; set; }
  }
}