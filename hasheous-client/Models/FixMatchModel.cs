namespace HasheousClient.Models
{
    public class FixMatchModel
    {
        public FixMatchModel()
        {

        }

        public FixMatchModel(string md5, string sha1, List<MetadataMatch> metadataMatches)
        {
            MD5 = md5;
            SHA1 = sha1;
            MetadataMatches = metadataMatches;
        }

        public string? MD5 { get; set; }
        public string? SHA1 { get; set; }
        public List<MetadataMatch>? MetadataMatches { get; set; }

        public class MetadataMatch
        {
            public MetadataMatch()
            {

            }

            public MetadataMatch(MetadataSources source, string platformId, string gameId)
            {
                Source = source;
                PlatformId = platformId;
                GameId = gameId;
            }
            
            public MetadataSources Source { get; set; }
            public string PlatformId { get; set; }
            public string GameId { get; set; }
        }
    }
}