using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetResponse.Net.Model
{
    public class PingResponse
    {
        public string Id { get; set; }
        public string Jsonrpc { get; set; }
        public string Result { get; set; }
    }
}
