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
        /// <summary>
        /// Set the default URL. The user
        /// can change this if they are using
        /// GetResponse 360 with a custom URL.
        /// </summary>
        public Client()
        {
            Url = "http://api2.getresponse.com";
        }

        public string Url { get; set; }
        public HttpClient HttpClient { get; set; }

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
                HttpClient.PostAsync(Url, content).Result;
            response.EnsureSuccessStatusCode();
            

            return 
                response.Content.ReadAsStringAsync().Result;
        }
    }
}
