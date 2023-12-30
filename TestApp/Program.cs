// See https://aka.ms/new-console-template for more information
using HasheousClient.Models;

HasheousClient.WebApp.HttpHelper.BaseUri = "https://hasheous.org/";

HasheousClient.Hasheous hasheous = new HasheousClient.Hasheous();

SignatureLookupItem? HasheousResult = hasheous.RetrieveFromHasheousAsync(new HashLookupModel{
    MD5 = "93bb1e1ee14ac53adb9e6b9e0c135043"
});

if (HasheousResult != null)
{
    string outString = Newtonsoft.Json.JsonConvert.SerializeObject(HasheousResult, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(outString);
}