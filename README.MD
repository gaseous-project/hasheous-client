# Hasheous Client

This repo contains a basic Hasheous Client .NET based applications.

## Setting up this client
1. Add the repo to your project: `dotnet add package hasheous-client`
2. Set the base URI:
```c#
HasheousClient.WebApp.HttpHelper.BaseUri = "https://hasheous.org/";
```
3. Set the Hasheous API key:
> **Note:** Only the metadata proxy and fix match endpoints require an API key.
>
> If you don't plan on using these endpoints, the API key can be safely ommitted.
```c#
HasheousClient.WebApp.HttpHelper.APIKey = "<Your API key here>";
```
4. Create a new Hasheous Client object:
```c#
HasheousClient.Hasheous hasheous = new HasheousClient.Hasheous();
```

## Methods
### MD5 Hash lookup
```c#
LookupItemModel? HasheousResult = hasheous.RetrieveFromHasheous(new HashLookupModel
{
    MD5 = "7a61d6a9bd7ac1a3249ef167ae136af7"
});
```

### SHA1 Hash lookup
```c#
LookupItemModel? HasheousResult = hasheous.RetrieveFromHasheous(new HashLookupModel
{
    SHA1 = "dc56fdcb9181b5ea04b95049997ceea2654aab78"
});
```

### Get Platforms
```c#
List<DataObjectItem> platforms = hasheous.GetPlatforms();
```

### Accessing the Metadata Proxy
#### Using an ID (long)
```c#
HasheousClient.Models.Metadata.IGDB.Game metadataProxy = hasheous.GetMetadataProxy<HasheousClient.Models.Metadata.IGDB.Game>(HasheousClient.Hasheous.MetadataProvider.IGDB, 3192);
```

#### Using a slug (string)
```c#
HasheousClient.Models.Metadata.IGDB.Game metadataProxy = hasheous.GetMetadataProxy<HasheousClient.Models.Metadata.IGDB.Game>(HasheousClient.Hasheous.MetadataProvider.IGDB, "sonic-the-hedgehog");
```