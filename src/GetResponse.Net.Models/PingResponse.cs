using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetResponse.Net.Models
{
    public class PingResponse : BaseResponse
    {
        public PingResult Result { get; set; }
    }
}
