using System;
using System.Collections.Generic;
using ForumApp.Core.Interfaces;
using ForumApp.Core.Models;
using RestSharp;

namespace ForumApp.Core.Services
{
    public class PostsService:RestService, IJsonPlaceHolderService<Posts>
    {
        readonly IRestClient _restClient;
        readonly IRestRequest _restRequest;
        private string path = "/post";


        public PostsService()
        {
            _restClient = CreateRestClient();
            _restRequest = CreateRestRequest(path);
        }

        public Posts Get()
        {
            
        }

        public List<Posts> GetAll()
        {
            var postsList = CreateRestResponse(_restClient, _restRequest);
        }
    }
}
