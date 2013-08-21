using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetResponse.Net.Models
{
    public class AccountInfoResult
    {
        public string FromEmail { get; set; }
        public DateTime CreatedOn { get; set; }
        public string FromName { get; set; }
        public string Login { get; set; }
    }
}
