using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContact.Core
{
    public class SocialProfile
    {

        [JsonProperty("typeId")]
        public string typeId { get; set; }

        [JsonProperty("typeNam")]
        public string TypeName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("rss")]
        public string Rss { get; set; }

    }

}