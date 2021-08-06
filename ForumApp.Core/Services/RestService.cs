using System;
using RestSharp;

namespace ForumApp.Core.Services
{
    public class RestService:Constants
    {
        public IRestClient CreateRestClient()
        {
            return new RestClient();
        }

        public IRestRequest CreateRestRequest(string path)
        {
            return new RestRequest(BaseUrl + path);
        }

        public IRestResponse CreateRestResponse(IRestClient client, IRestRequest restRequest)
        {
            return client.Get(restRequest);
        }
    }
}
