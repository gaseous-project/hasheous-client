using HasheousClient.Models;

namespace HasheousClient
{
    public class Hasheous
    {
        public SignatureLookupItem RetrieveFromHasheousAsync(HashLookupModel hash)
        {
            Task<SignatureLookupItem> result = _RetrieveFromHasheousAsync(hash);   

            return result.Result;
        }

        private async Task<SignatureLookupItem> _RetrieveFromHasheousAsync(HashLookupModel hashLookup)
        {
            var result = await HasheousClient.WebApp.HttpHelper.Post<SignatureLookupItem>($"/api/v1/HashLookup/Lookup", hashLookup);

            return result;
        }
    }
}