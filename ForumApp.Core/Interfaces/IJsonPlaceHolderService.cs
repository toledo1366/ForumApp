using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForumApp.Core.Models;
using Refit;

namespace ForumApp.Core.Interfaces
{
    public interface IJsonPlaceHolderService
    {
        [Get("/posts/id")]
        Task<Posts> GetPost(int id);

        [Get("/posts")]
        Task<List<Posts>> GetPosts();

        [Get("/comments?postId={id}")]
        Task<List<Comment>> GetComments([AliasAs("id")] int id);
    }
}
