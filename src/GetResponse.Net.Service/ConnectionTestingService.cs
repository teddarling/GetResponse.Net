using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetResponse.Net.Service
{
    public class ConnectionTestingService
    {
        private string _key;
        private Client _client;

        public ConnectionTestingService(string apiKey, Client client)
        {
            // If the key is null or empty, 
            // then throw an exception
            if (String.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException("apiKey");

            _key = apiKey;
            _client = client;
        }

        public string Ping()
        {
            return _client.GetResult("{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"ping\",\"params\":[\"" + _key + "\"]}");
        }
    }
}
