namespace HasheousClient.Models
{
    public class DataObjectItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Dictionary<string, object>>? SignatureDataObjects { get; set; }
        public List<MetadataItem>? Metadata { get; set; }
        public List<AttributeItem>? Attributes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class DataObjectsList
    {
        public List<DataObjectItem> Objects { get; set; }
        public int Count { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }

    public enum DataObjectType
    {
        Company = 0,
        Platform = 1,
        Game = 2,
        ROM = 3,
        None = 100
    }
}