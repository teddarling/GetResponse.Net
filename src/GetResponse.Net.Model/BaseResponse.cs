using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetResponse.Net.Model
{
    public class BaseResponse
    {
        // Json RPC values. Result left out as different
        // GetResponse results have different types.
        public string Id { get; set; }
        public string Jsonrpc { get; set; }
        public Error Error { get; set; }

        // Some Http data about the result.
        public HttpStatusCode StatusCode { get; set; }
    }
}
