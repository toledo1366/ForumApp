using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForumApp.Core.Interfaces;
using ForumApp.Core.Models;
using ForumApp.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ForumApp.Core.ViewModels
{
    public class PostsViewModel:MvxViewModel
    {
        readonly IJsonPlaceHolderService _jsonPlaceHolderService;
        readonly IMvxNavigationService _navigationService;

        public PostsViewModel(IJsonPlaceHolderService jsonPlaceHolderService, IMvxNavigationService navigationService)
        {
            _jsonPlaceHolderService = jsonPlaceHolderService;
            _navigationService = navigationService;
            NavigateCommand = new MvxCommand<Posts>(post => _navigationService.Navigate<CommentViewModel, Posts>(post));
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

        private IMvxCommand<Posts> _navigateCommand;
        public IMvxCommand<Posts> NavigateCommand
        {
            get => _navigateCommand;
            set
            {
                _navigateCommand = value;
                RaisePropertyChanged(()=>NavigateCommand);
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
