using FullContact.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContact.PersonApi.Models
{

    public class FullContactPerson
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("likelihood")]
        public float Likelihood { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("contactInfo")]
        public ContactInfo ContactInfo { get; set; }

        [JsonProperty("demographics")]
        public Demographics Demographics { get; set; }

        [JsonProperty("socialProfiles")]
        public List<SocialProfile> SocialProfiles { get; set; }

        [JsonProperty("organizations")]
        public List<Organization> Organizations { get; set; }

        [JsonProperty("digitalFootprint")]
        public Digitalfootprint DigitalFootprint { get; set; }

        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }

    }

    public class ContactInfo
    {

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("websites")]
        public List<Website> Websites { get; set; }

    }

    public class Website
    {

        [JsonProperty("url")]
        public string Url { get; set; }

    }

    public class Demographics
    {

        [JsonProperty("locationGeneral")]
        public string GeneralLocation { get; set; }

        [JsonProperty("locationDeduced")]
        public DeducedLocation DeducedLocation { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("ageRange")]
        public string AgeRange { get; set; }

    }

    public class DeducedLocation
    {

        [JsonProperty("normalizedLocation")]
        public string NormalizedLocation { get; set; }

        [JsonProperty("deducedLocation")]
        public string Location { get; set; }

        [JsonProperty("city")]
        public Geography City { get; set; }

        [JsonProperty("state")]
        public CodedGeography State { get; set; }

        [JsonProperty("country")]
        public CodedGeography Country { get; set; }

        [JsonProperty("continent")]
        public Geography Continent { get; set; }

        [JsonProperty("county")]
        public CodedGeography County { get; set; }

        [JsonProperty("likelihood")]
        public float Likelihood { get; set; }

    }

    
    public class Digitalfootprint
    {

        [JsonProperty("topics")]
        public List<Topic> Topics { get; set; }

        [JsonProperty("scores")]
        public List<Score> Scores { get; set; }

    }

    public class Topic
    {

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }
    }

    public class Score
    {

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

    }

    public class Organization
    {

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

    }

    public class Photo
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

    }



}
