using Newtonsoft.Json;

namespace FullContact.Core
{

    /// <summary>
    /// 
    /// </summary>
    public class MediaResource
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

    }

}