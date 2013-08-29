using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GetResponse.Net.Service
{
    public class Client
    {
        private string _url;
        private HttpClient _client;

        /// <summary>
        /// Create a client to access the GetResponse
        /// API using the default URL.
        /// </summary>
        public Client()
            : this("http://api2.getresponse.com/")
        { }

        /// <summary>
        /// Create a client to access the GetResponse
        /// API using a custom URL (for GetResponse 360).
        /// </summary>
        /// <param name="url">String - URL to the API.</param>
        public Client(string url)
            : this(url, new HttpClientHandler())
        { }

        /// <summary>        /// 
        /// Create a client to access the GetResponse
        /// API using a custom URL (for GetResponse 360)
        /// and/or message handler.
        /// </summary>
        /// <param name="url">String - URL to the API</param>
        /// <param name="handler">HttpMessageHandler - 
        /// handler for processing the API results</param>
        public Client(string url, HttpMessageHandler handler)
        {
            _url = url;

            _client = new HttpClient(handler);
        }

        /// <summary>
        /// Get a result from the GetResponse API
        /// in a syncronous way.
        /// </summary>
        /// <param name="request">String - 
        /// the request to send to the API.</param>
        /// <returns>String - 
        /// the result from the API endpoint.</returns>
        public string GetResult(string request)
        {
            var response = GetResultAsync(request);
            response.Wait();

            return response.Result;
        }

        /// <summary>  
        /// Get a result from the GetResponse API
        /// in a syncronous way.
        /// 
        /// Throws an AggregateException if the
        /// status code from the API is not a success.
        /// </summary>
        /// <param name="request">String - 
        /// the request to send to the API.</param>
        /// <returns>Task - 
        /// the result from the API endpoint.</returns>
        public async Task<string> GetResultAsync(string request)
        {
            var content = new StringContent(request);
            content.Headers.ContentType = 
                new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = 
                _client.PostAsync(_url, content).Result;
            response.EnsureSuccessStatusCode();
            

            return 
                response.Content.ReadAsStringAsync().Result;
        }
    }
}
