using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForumApp.Core.Interfaces;
using ForumApp.Core.Models;
using Refit;

namespace ForumApp.Core.Services
{
    public class JsonPlaceHolderService : Constants, IJsonPlaceHolderService
    {
        readonly IJsonPlaceHolderService restApi;

        public JsonPlaceHolderService()
        {
            restApi = RestService.For<IJsonPlaceHolderService>(BaseUrl);
        }

        public async Task<List<Comment>> GetComments(int id)
        {
            return await restApi.GetComments(id);
        }

        public async Task<Posts> GetPost(int id)
        {
            return await restApi.GetPost(id);
        }

        public async Task<List<Posts>> GetPosts()
        {
            return await restApi.GetPosts();
        }
    }
}
