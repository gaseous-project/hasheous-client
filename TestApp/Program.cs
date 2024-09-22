// See https://aka.ms/new-console-template for more information
using HasheousClient.Models;

HasheousClient.WebApp.HttpHelper.BaseUri = "https://hasheous.org/";

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