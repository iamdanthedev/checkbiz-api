using System;
using System.Threading.Tasks;
using CheckbizApi.Model;
using RestSharp;
using RestSharp.Authenticators;

namespace CheckbizApi
{
    public class CheckbizClient
    {
        private readonly RestClient _client;

        public CheckbizClient(string username, string password)
        {
            _client = new RestClient("https://api.checkbiz.se/api/v1")
            {
                Authenticator = new HttpBasicAuthenticator(username, password)
            };
        }
        
        public async Task<object> LookupIdNoAsync(string id)
        {
            var request = new RestRequest("lookupidno", DataFormat.Json);
            request.AddHeader("Package", "LookupIdNo");
            request.AddQueryParameter("Id", id);

            return await _client.GetAsync<object>(request);
        }
        
    }
}