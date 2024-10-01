// See https://aka.ms/new-console-template for more information
using HasheousClient.Models;

HasheousClient.WebApp.HttpHelper.BaseUri = "https://hasheous.org/";
HasheousClient.WebApp.HttpHelper.APIKey = "";

HasheousClient.Hasheous hasheous = new HasheousClient.Hasheous();

LookupItemModel? HasheousResult = hasheous.RetrieveFromHasheous(new HashLookupModel
{
    MD5 = "7a61d6a9bd7ac1a3249ef167ae136af7"
});

if (HasheousResult != null)
{
    Newtonsoft.Json.JsonSerializerSettings jsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
    {
        Formatting = Newtonsoft.Json.Formatting.Indented,
        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
    };
    jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
    string outString = Newtonsoft.Json.JsonConvert.SerializeObject(HasheousResult, jsonSerializerSettings);
    Console.WriteLine(outString);
}

List<DataObjectItem> platforms = hasheous.GetPlatforms();
for (int i = 0; i < platforms.Count; i++)
{
    Console.WriteLine(i + ": " + platforms[i].Name);
}

HasheousClient.Models.Metadata.IGDB.Game metadataProxy = hasheous.GetMetadataProxy<HasheousClient.Models.Metadata.IGDB.Game>(HasheousClient.Hasheous.MetadataProvider.IGDB, 3192);
if (metadataProxy != null)
{
    Newtonsoft.Json.JsonSerializerSettings jsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
    {
        Formatting = Newtonsoft.Json.Formatting.Indented,
        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
        MaxDepth = 8
    };
    jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
    string outString = Newtonsoft.Json.JsonConvert.SerializeObject(metadataProxy, jsonSerializerSettings);
    Console.WriteLine(outString);
}