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
                return client.BaseAddress.ToString();
            }
            set
            {
                client.BaseAddress = new Uri(value);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public static void AddHeader(string name, string value)
        {
            if (client.DefaultRequestHeaders.Contains(name))
            {
                client.DefaultRequestHeaders.Remove(name);
            }
            client.DefaultRequestHeaders.Add(name, value);
        }

        public static string APIKey
        {
            get
            {
                return client.DefaultRequestHeaders.GetValues("APIKey").FirstOrDefault();
            }
            set
            {
                AddHeader("APIKey", value);
            }
        }

        private static HttpClient client = new HttpClient();

        public static async Task<T> Post<T>(string url, object contentValue)
        {
            //var jsonContent = JsonContent.Create(contentValue);
            var stringContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
            await stringContent.LoadIntoBufferAsync();
            var response = await client.PostAsync(url, stringContent);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            var resultStr = await response.Content.ReadAsStringAsync();
            var resultObject = JsonConvert.DeserializeObject<T>(resultStr);
            return resultObject;
        }

        // public static async Task Put<T>(string url, T stringValue)
        // {
        //     Client.BaseAddress = new Uri(apiBasicUri);
        //     var content = new StringContent(JsonConvert.SerializeObject(stringValue), Encoding.UTF8, "application/json");
        //     var result = await Client.PutAsync(url, content);
        //     result.EnsureSuccessStatusCode();
        // }

        public static async Task<T> Get<T>(string url)
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Get the response
            string resultStr = await response.Content.ReadAsStringAsync();

            // Deserialize the response to T
            T resultObject = JsonConvert.DeserializeObject<T>(resultStr, new JsonSerializerSettings
            {
                MaxDepth = 8,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                CheckAdditionalContent = true
            });
            return resultObject;
        }

        // public static async Task Delete(string url)
        // {
        //     Client.BaseAddress = new Uri(apiBasicUri);
        //     var result = await Client.DeleteAsync(url);
        //     result.EnsureSuccessStatusCode();
        // }
    }
}