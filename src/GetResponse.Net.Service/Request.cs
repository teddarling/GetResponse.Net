using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GetResponse.Net.Service
{
    public class Request
    {
        public Request() { }

        public string Id { get; set; }

        public string Jsonrpc { get; set; }

        public string Method { get; set; }

        public object[] Params { get; set; }

        [JsonIgnore]
        public HttpClient Client { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, new JsonSerializerSettings
            {
                ContractResolver = new LowerCaseUnderscoreContractResolver()
            });
        }
    }
}
