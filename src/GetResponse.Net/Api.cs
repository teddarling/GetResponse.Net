using GetResponse.Net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace GetResponse.Net
{
    public class Api
    {
        private string _apiKey;
        private string _apiUrl;
        private HttpClient _client;

        public Api(string apiKey, string apiUrl, HttpClient httpClient)
        {
            this._apiKey = apiKey;
            this._apiUrl = apiUrl;
            this._client = httpClient;
        }

        public PingResponse Ping()
        {
            return new PingResponse
            {
                Id = "1",
                Jsonrpc = "2.0",
                Result = "{\"jsonrpc\":\"2.0\",\"id\":\"1\",\"result\":{\"ping\":\"pong\"}}"
            };
        }
    }
}
