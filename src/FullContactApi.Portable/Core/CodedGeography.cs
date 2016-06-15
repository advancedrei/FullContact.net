using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContact.Core
{
    public class CodedGeography : Geography
    {

        [JsonProperty("code")]
        public string Code { get; set; }

    }

}