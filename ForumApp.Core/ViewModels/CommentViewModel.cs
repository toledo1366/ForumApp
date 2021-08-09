using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForumApp.Core.Interfaces;
using ForumApp.Core.Models;
using MvvmCross.ViewModels;

namespace ForumApp.Core.ViewModels
{
    public class CommentViewModel:MvxViewModel<Posts>
    {
        readonly IJsonPlaceHolderService _jsonPlaceHolderService;

        public CommentViewModel(IJsonPlaceHolderService jsonPlaceHolderService)
        {
            _jsonPlaceHolderService = jsonPlaceHolderService;
        }


        private string _postBody;
        public string PostBody
        {
            get => _postBody;
            set
            {
                _postBody = value;
                RaisePropertyChanged(() => PostBody);
            }
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        private List<Comment> _comments;
        public List<Comment> Comments
        {
            get => _comments;
            set
            {
                _comments = value;
                RaisePropertyChanged(() => Comments);
            }
        }

        public override async void Prepare(Posts parameter)
        {
            PostBody = parameter.Body;
            Title = parameter.Title;

            await GetCommentsList(parameter.Id);
        }

        private async Task GetCommentsList(int id)
        {
            Comments = await _jsonPlaceHolderService.GetComments(id);
        }
    }
}
