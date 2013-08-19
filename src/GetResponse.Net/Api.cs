using GetResponse.Net.Model;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GetResponse.Net
{
    public class Api
    {
        private string _apiKey;
        private string _apiUrl;
        private HttpClient _client;

        public Api(string apiKey, string apiUrl, HttpClient httpClient)
        {
            _apiKey = apiKey;
            _apiUrl = apiUrl;
            _client = httpClient;
        }

        public string Ping()
        {
            var data = "{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"ping\",\"params\":[\"" + _apiKey + "\"]}";
            var content = new StringContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = _client.PostAsync(_apiUrl, content).Result;

            return result.Content.ReadAsStringAsync().Result;
        }
    }
}
