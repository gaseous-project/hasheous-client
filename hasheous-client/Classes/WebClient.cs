using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HasheousClient.WebApp
{
    public static class HttpHelper
    {
        public static string BaseUri
        {
            get
            {
                return client.BaseAddress != null ? client.BaseAddress.ToString() : string.Empty;
            }
            set
            {
                client.BaseAddress = new Uri(value);

                BuildHeaders();
            }
        }

        private static void BuildHeaders()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
            {
                NoCache = true
            };

            // add client supplied headers
            if (Headers != null)
            {
                foreach (KeyValuePair<string, string> header in Headers)
                {
                    if (client.DefaultRequestHeaders.Contains(header.Key))
                    {
                        client.DefaultRequestHeaders.Remove(header.Key);
                    }
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            // remove keys if they exist
            if (client.DefaultRequestHeaders.Contains("X-API-Key"))
            {
                client.DefaultRequestHeaders.Remove("X-API-Key");
            }
            if (client.DefaultRequestHeaders.Contains("X-Client-API-Key"))
            {
                client.DefaultRequestHeaders.Remove("X-Client-API-Key");
            }

            // add keys if they exist
            if (!string.IsNullOrEmpty(APIKey))
            {
                client.DefaultRequestHeaders.Add("X-API-Key", APIKey);
            }
            if (!string.IsNullOrEmpty(ClientKey))
            {
                client.DefaultRequestHeaders.Add("X-Client-API-Key", ClientKey);
            }
        }

        public static string APIKey { get; set; } = "";
        public static string ClientKey { get; set; } = "";
        public static Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        private static HttpClient client = new HttpClient();

        public static async Task<T> Post<T>(string url, object contentValue)
        {
            // ensure headers are built
            BuildHeaders();

            var stringContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
            await stringContent.LoadIntoBufferAsync();
            var response = await client.PostAsync(url, stringContent);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            var resultStr = await response.Content.ReadAsStringAsync();
            var resultObject = JsonConvert.DeserializeObject<T>(resultStr);
            if (resultObject == null)
            {
                throw new InvalidOperationException("Deserialization returned null for type " + typeof(T).FullName);
            }
            return resultObject;
        }

        public static async Task<T> Get<T>(string url)
        {
            // ensure headers are built
            BuildHeaders();

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Get the response
            string resultStr = await response.Content.ReadAsStringAsync();

            // Deserialize the response to T
            T? resultObject = JsonConvert.DeserializeObject<T>(resultStr, new JsonSerializerSettings
            {
                MaxDepth = 8,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                CheckAdditionalContent = true
            });
            if (resultObject == null)
            {
                throw new InvalidOperationException("Deserialization returned null for type " + typeof(T).FullName);
            }
            return resultObject;
        }
    }
}