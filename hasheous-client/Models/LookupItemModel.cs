namespace HasheousClient.Models
{
    /// <summary>
    /// Model returned from the Hasheous server containing metadata about the requested signature, and mappings to public metadata sources
    /// </summary>
    public class LookupItemModel
    {
        /// <summary>
        /// Hasheous internal id of the game mapping
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Name of the game
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Data about the signature and rom (provided by DATs loaded into Hasheous)
        /// </summary>
        public SignatureModel? Signature { get; set; }

        /// <summary>
        /// Platform metadata maps to public metadata sources
        /// </summary>
        public MiniDataObjectItem Platform { get; set; }

        /// <summary>
        /// Publisher metadata maps to public metadata sources
        /// </summary>
        public MiniDataObjectItem Publisher { get; set; }

        /// <summary>
        /// Game metadata maps to public metadata sources
        /// </summary>
        public List<MetadataItem>? Metadata { get; set; }

        /// <summary>
        /// Attributes associated with the game mapping
        /// </summary>
        public List<AttributeItemCompiled>? Attributes { get; set; }

        /// <summary>
        /// Contains a list of metadata maps for various public metadata sources
        /// </summary>
        public class MiniDataObjectItem
        {
            /// <summary>
            /// The name of the metadata map in Hasheous
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// The metadata map
            /// </summary>
            public List<MetadataItem> metadata { get; set; }
        }
    }

    /// <summary>
    /// Supported metadata sources
    /// </summary>
    public enum MetadataSources
    {
        /// <summary>
        /// None - always returns null for metadata requests - should not really be using this source
        /// </summary>
        None,

        /// <summary>
        /// IGDB - queries the IGDB service for metadata
        /// </summary>
        IGDB,

        /// <summary>
        /// TheGamesDb - queries TheGamesDb service for metadata
        /// </summary>
        TheGamesDb
    }

    /// <summary>
    /// The method used to match the signature to the IGDB source
    /// </summary>
    public enum MatchMethod
    {
        /// <summary>
        /// No match
        /// </summary>
        NoMatch = 0,

        /// <summary>
        /// Automatic matches are subject to change - depending on IGDB
        /// </summary>
        Automatic = 1,

        /// <summary>
        /// Manual matches will never change
        /// </summary>
        Manual = 2,

        /// <summary>
        /// Too many matches to successfully match
        /// </summary>
        AutomaticTooManyMatches = 3,

        /// <summary>
        /// Manually set by an admin - will never change unless set by an admin
        /// </summary>
        ManualByAdmin = 4,

        /// <summary>
        /// Match made by vote
        /// </summary>
        Voted = 5
    }
}