using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetResponse.Net.Service
{
    public class Response
    {
        public string Id { get; set; }
        public string Jsonrpc { get; set; }
        public object Result { get; set; }
    }
}
