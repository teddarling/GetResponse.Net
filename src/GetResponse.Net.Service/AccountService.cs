using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetResponse.Net.Service
{
    public class AccountService : BaseService
    {
        public string GetInfo()
        {
            return Client.GetResult("{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"get_account_info\",\"params\":[\"" + Key + "\"]}");
        }

        public string GetFromFields()
        {
            return Client.GetResult("{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"get_account_info\",\"params\":[\"" + Key + "\"]}");
        }

        public string GetFromField(string fromId)
        {
            return Client.GetResult("{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"get_account_info\",\"params\":[\"" + Key + "\"]}");
        }
    }
}
