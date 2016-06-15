using FullContact.PersonApi.Models;
using PortableRest;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FullContact
{
    public class FullContactClient : RestClient
    {

        #region Constructors

        public FullContactClient(string apiKey)
        {
            BaseUrl = "https://api.fullcontact.com/v2";
            AddHeader("X-FullContact-APIKey", apiKey);
        }

        #endregion

        #region GetPersonfromEmailAsync

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        public async Task<FullContactPerson> GetPersonFromEmailAsync(string emailAddress)
        {
            var request = new RestRequest("person.json", HttpMethod.Get, ContentTypes.Json);
            request.AddQueryString("email", emailAddress);

            //return await ExecuteAsync<FullContactPerson>(request);
            var response = await SendAsync<FullContactPerson>(request);

            switch (response.HttpResponseMessage.StatusCode)
            {
                case HttpStatusCode.OK:
                    return response.Content;
                case HttpStatusCode.Accepted:
                    //Need to return something indicating the request was OK.
                    return new FullContactPerson();
                default:
                    return null;
            }

        }

        #endregion

    }

}