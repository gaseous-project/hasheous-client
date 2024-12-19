namespace HasheousClient.Models
{
    /// <summary>
    /// Contains the metadata map for a single metadata source
    /// </summary>
    public class MetadataItem
    {
        /// <summary>
        /// The id to map to from the metadata source
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The immutable id to map to from the metadata source
        /// </summary>
        public string? ImmutableId { get; set; }

        /// <summary>
        /// The method used to match to the metadata source
        /// </summary>
        public MatchMethod? MatchMethod { get; set; }

        /// <summary>
        /// The metadata source provider
        /// </summary>
        public MetadataSources Source { get; set; }

        /// <summary>
        /// A link to the metadata source
        /// </summary>
        public string? Link { get; set; }

        /// <summary>
        /// The last time the metadata source was queried - only valid for unmatched metadata
        /// </summary>
        public DateTime LastSearch { get; set; }

        /// <summary>
        /// The next time the metadata source should be queried - only valid for unmatched metadata
        /// </summary>
        public DateTime NextSearch { get; set; }

        /// <summary>
        /// The number of times the winning vote has been submitted
        /// </summary>
        public int WinningVoteCount { get; set; }

        /// <summary>
        /// The total number of votes
        /// </summary>
        public int TotalVoteCount { get; set; }

        /// <summary>
        /// The percent of votes that are winning
        /// </summary>
        public uint? WinningVotePercent { get; set; }
    }
}