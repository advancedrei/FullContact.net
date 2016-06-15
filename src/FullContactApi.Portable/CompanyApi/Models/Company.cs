using FullContact.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContact.CompanyApi.Models
{


    public class FullContactCompany
    {

        [JsonProperty("url")]
        public int status { get; set; }

        [JsonProperty("url")]
        public string requestId { get; set; }

        [JsonProperty("url")]
        public Category[] category { get; set; }

        [JsonProperty("url")]
        public string logo { get; set; }

        [JsonProperty("url")]
        public string website { get; set; }

        [JsonProperty("url")]
        public string languageLocale { get; set; }

        [JsonProperty("url")]
        public Organization organization { get; set; }

        [JsonProperty("url")]
        public List<SocialProfile> socialProfiles { get; set; }

        [JsonProperty("url")]
        public Traffic traffic { get; set; }
    }

    public class Organization
    {

        [JsonProperty("url")]
        public string name { get; set; }

        [JsonProperty("url")]
        public int approxEmployees { get; set; }

        [JsonProperty("url")]
        public string founded { get; set; }

        [JsonProperty("url")]
        public string overview { get; set; }

        [JsonProperty("url")]
        public Contactinfo contactInfo { get; set; }

        [JsonProperty("url")]
        public List<MediaResource> links { get; set; }

        [JsonProperty("url")]
        public List<MediaResource> images { get; set; }

        [JsonProperty("url")]
        public string[] keywords { get; set; }
    }

    public class Contactinfo
    {

        [JsonProperty("url")]
        public Emailaddress[] emailAddresses { get; set; }

        [JsonProperty("url")]
        public Phonenumber[] phoneNumbers { get; set; }

        [JsonProperty("url")]
        public Address[] addresses { get; set; }
    }

    public class Emailaddress
    {
        public string value { get; set; }
        public string label { get; set; }
    }

    public class Phonenumber
    {
        public string number { get; set; }
        public string label { get; set; }
    }

    public class Address
    {
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string locality { get; set; }
        public CodedGeography region { get; set; }
        public CodedGeography country { get; set; }
        public string postalCode { get; set; }
        public string label { get; set; }
    }

    public class Traffic
    {
        public Ranking[] topCountryRanking { get; set; }
        public Ranking[] ranking { get; set; }
    }

    public class Ranking
    {
        public int rank { get; set; }
        public string locale { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string code { get; set; }
    }




}
