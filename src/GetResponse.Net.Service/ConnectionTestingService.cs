using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetResponse.Net.Service
{
    public class ConnectionTestingService : BaseService
    {
        public string Ping()
        {
            return Client.GetResult("{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"ping\",\"params\":[\"" + Key + "\"]}");
        }
    }
}
