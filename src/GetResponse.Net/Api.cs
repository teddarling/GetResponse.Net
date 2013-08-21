using GetResponse.Net.Models;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GetResponse.Net
{
    public class Api
    {
        private string _key;
        private string _url;
        private HttpClient _client;

        public Api(string apiKey, string apiUrl) :
            this(apiKey, apiUrl, new HttpClient())
        {
        }

        public Api(string apiKey, string apiUrl, HttpClient httpClient)
        {
            // Throw error if no key or URL
            if (String.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException("apiKey");

            if (String.IsNullOrEmpty(apiUrl))
                throw new ArgumentNullException("apiUrl");

            _key = apiKey;
            _url = apiUrl;
            _client = httpClient;

            // Config ServiceStack Json.
            JsConfig.EmitLowercaseUnderscoreNames = true;
            JsConfig.EmitCamelCaseNames = false;
            JsConfig.ExcludeTypeInfo = true;
            JsConfig.IncludeNullValues = false;
            JsConfig.PropertyConvention = JsonPropertyConvention.Lenient;
        }

        public PingResponse Ping()
        {
            var data = "{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"ping\",\"params\":[\"" + _key + "\"]}";
            var content = new StringContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = _client.PostAsync(_url, content).Result;
            
            var result = response.Content.ReadAsStringAsync().Result;

            var pingResponse = result.FromJson<PingResponse>();

            // If pingResponse is null (bad URL, Http error, etc...)
            // Then set to new.
            if (pingResponse == null)
                pingResponse = new PingResponse();

            pingResponse.StatusCode = response.StatusCode;

            return pingResponse;
        }

        public AccountInfoResponse AccountInfo()
        {
            var data = "{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"get_account_info\",\"params\":[\"" + _key + "\"]}";
            var content = new StringContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = _client.PostAsync(_url, content).Result;

            var result = response.Content.ReadAsStringAsync().Result;

            var infoResponse = result.FromJson<AccountInfoResponse>();

            // If pingResponse is null (bad URL, Http error, etc...)
            // Then set to new.
            if (infoResponse == null)
                infoResponse = new AccountInfoResponse();

            infoResponse.StatusCode = response.StatusCode;

            return infoResponse;
        }
    }
}
