using System.Collections.Generic;
using ForumApp.Core.Interfaces;
using ForumApp.Core.Models;

namespace ForumApp.Core.Services
{
    public class PostsService:RestService, IJsonPlaceHolderService<Posts>
    {

        private string path = "/posts";


        public PostsService()
        {

        }

        public Posts Get()
        {
            return null;
        }

        public List<Posts> GetAll()
        {
            return null;
        }
    }
}
