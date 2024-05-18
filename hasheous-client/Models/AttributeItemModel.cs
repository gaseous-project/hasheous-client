namespace HasheousClient.Models
{
    public class AttributeItem
    {
        public enum AttributeType
        {
            LongString = 0,
            ShortString = 1,
            DateTime = 2,
            ImageId = 3,
            ImageAttribution = 4,
            ObjectRelationship = 10,
            EmbeddedList = 11
        }

        public enum AttributeName
        {
            Description = 0,
            Manufacturer = 1,
            Publisher = 2,
            Logo = 3,
            Platform = 4,
            Year = 5,
            Country = 6,
            Language = 7,
            ROMs = 8,
            VIMMManualId = 9,
            LogoAttribution = 10
        }

        public long? Id { get; set; }
        public AttributeType attributeType { get; set; }
        public AttributeName attributeName { get; set; }
        public DataObjectType attributeRelationType { get; set; }
        public object? Value { get; set; }
    }

    public class AttributeItemCompiled : AttributeItem
    {
        public string? Link { get; set; }
    }

    public class RelationItem
    {
        public DataObjectType relationType { get; set; }
        public long relationId { get; set; }
    }
}