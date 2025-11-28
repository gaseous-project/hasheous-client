// See https://aka.ms/new-console-template for more information
using HasheousClient.Models;

HasheousClient.WebApp.HttpHelper.BaseUri = "https://beta.hasheous.org/";
HasheousClient.WebApp.HttpHelper.APIKey = "";
HasheousClient.WebApp.HttpHelper.ClientKey = "rMnTbIjaCYtfDfCMX3Mes55rgBdrbUMfP2jgW_Nz2nYQdQ8EgHVZR0zfyvbd957x";

HasheousClient.Hasheous hasheous = new HasheousClient.Hasheous();

Console.WriteLine("Fetching data from Hasheous...");
LookupItemModel? HasheousResult = hasheous.RetrieveFromHasheous(new HashLookupModel
{
    MD5 = "cff69b70a8ad674a0efe5558765855c9"
}, "TOSEC, MAMEArcade, MAMEMess, NoIntros, Redump, WHDLoad, RetroAchievements, FBNeo");

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

Console.WriteLine("Fetching platforms from Hasheous...");
List<DataObjectItem> platforms = hasheous.GetPlatforms();
for (int i = 0; i < platforms.Count; i++)
{
    Console.WriteLine(i + ": " + platforms[i].Name);
}

Console.WriteLine("Fetching metadata via metadata proxy from Hasheous...");
HasheousClient.Models.Metadata.IGDB.Game metadataProxy = hasheous.GetMetadataProxy<HasheousClient.Models.Metadata.IGDB.Game>(HasheousClient.Models.MetadataSources.IGDB, 3192);
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
