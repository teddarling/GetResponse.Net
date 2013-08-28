using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace GetResponse.Net.Service
{
    public class Client
    {
        private string _url;
        private HttpClient _client;

        public Client(string url)
        {
            _url = url;

            _client = new HttpClient();
        }

        public Client(string url, HttpMessageHandler handler)
        {
            _url = url;

            _client = new HttpClient(handler);
        }

        public string GetResult(string request)
        {
            var content = new StringContent(request);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = _client.PostAsync(_url, content).Result;

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
