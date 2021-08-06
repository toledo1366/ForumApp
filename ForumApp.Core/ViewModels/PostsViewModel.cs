using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForumApp.Core.Interfaces;
using ForumApp.Core.Models;
using ForumApp.Core.Services;
using MvvmCross.ViewModels;

namespace ForumApp.Core.ViewModels
{
    public class PostsViewModel:MvxViewModel
    {
        readonly IJsonPlaceHolderService _jsonPlaceHolderService;

        public PostsViewModel(IJsonPlaceHolderService jsonPlaceHolderService)
        {
            _jsonPlaceHolderService = jsonPlaceHolderService;
        }

        private List<Posts> _postsList;
        public List<Posts> PostsList
        {
            get => _postsList;
            set
            {
                _postsList = value;
                RaisePropertyChanged(() => PostsList);
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            GetPosts();
        }

        private async void GetPosts()
        {
            PostsList = await _jsonPlaceHolderService.GetPosts();
        }
    }
}
