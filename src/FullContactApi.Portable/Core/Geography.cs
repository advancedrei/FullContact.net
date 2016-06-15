using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContact.Core
{
    public class Geography
    {

        [JsonProperty("deduced")]
        public bool IsDeduced { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }

}