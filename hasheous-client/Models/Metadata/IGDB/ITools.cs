using System.Reflection;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
    public class ITools
    {
        public static T ConvertFromIGDB<T>(object source, T destination) where T : ITools
        {
            Dictionary<string, object> tempDestination = new Dictionary<string, object>();
            foreach (PropertyInfo property in source.GetType().GetProperties())
            {
                // property type example: IGDB.IdentitiesOrValues`1[IGDB.Models.AlternativeName]
                string propertyTypeName = property.PropertyType.Name.StartsWith("IGDB.") ? property.PropertyType.Name.Substring(5) : property.PropertyType.Name;
                propertyTypeName = propertyTypeName.Split('`')[0];

                var srcValue = property.GetValue(source);
                var destinationProperty = destination.GetType().GetProperty(property.Name);

                // get the json property name if it exists
                string propertyName = property.Name;
                try
                {
                    var jsonProperty = destinationProperty.GetCustomAttribute<JsonPropertyAttribute>();
                    var jsonPropertyName = jsonProperty?.PropertyName;
                    propertyName = jsonPropertyName != null ? jsonPropertyName : property.Name;
                }
                catch (Exception e)
                {
                    propertyName = property.Name;
                }

                if (srcValue != null)
                {
                    switch (propertyTypeName)
                    {
                        case "IdentityOrValue":
                            // property has a child property called "id" which should be copied to the destination property
                            PropertyInfo idProperty = property.PropertyType.GetProperty("Id");
                            if (idProperty != null)
                            {
                                var idValue = idProperty.GetValue(srcValue);
                                if (idValue != null)
                                {
                                    tempDestination.Add(propertyName, idValue);
                                }
                            }
                            break;

                        case "IdentitiesOrValues":
                            // // property has a child property called "ids" which should be copied to the destination property
                            PropertyInfo idsProperty = property.PropertyType.GetProperty("Ids");
                            if (idsProperty != null)
                            {
                                var idsValue = idsProperty.GetValue(srcValue);
                                if (idsValue != null)
                                {
                                    tempDestination.Add(propertyName, idsValue);
                                }
                            }
                            break;

                        default:
                            bool isEnum = property.GetValue(source) is Enum;
                            if (isEnum)
                            {
                                string srcEnum = property.GetValue(source).ToString();

                                tempDestination.Add(propertyName, srcEnum);
                            }
                            else
                            {
                                tempDestination.Add(propertyName, property.GetValue(source));
                            }
                            break;
                    }
                }
            }

            // serialize the dictionary to a json string, then deserialize it to the destination object
            string json = JsonConvert.SerializeObject(tempDestination);
            destination = JsonConvert.DeserializeObject<T>(json);

            return destination;
        }

        public static IEnumerable<string> RetrievalUsingReflection(object obj)
        {
            foreach (var property in obj.GetType().GetProperties())
            {
                var jsonProperty = property.GetCustomAttribute<JsonPropertyAttribute>();
                var jsonPropertyName = jsonProperty?.PropertyName;
                yield return jsonPropertyName != null
                    ? jsonPropertyName
                    : property.Name;
            }
        }
    }
}

namespace HasheousClient.Models.Metadata.IGDB.Override
{
    public class IdentitiesOrValues
    {
        public List<long> Ids { get; set; }
    }

    public class IdentityOrValue
    {
        public long Id { get; set; }
    }
}