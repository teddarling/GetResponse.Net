using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GetResponse.Net.Service
{
    class LowerCaseUnderscoreContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            var regex = new Regex("(?!(^[A-Z]))([A-Z])");

            return regex.Replace(propertyName, "_$2").ToLower();
        }
    }
}
