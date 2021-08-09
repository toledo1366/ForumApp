using Android.App;
using Android.OS;
using ForumApp.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace ForumApp.Droid.Views
{
    [Activity(Label = "CommentsView")]
    public class CommentsView : MvxActivity<CommentViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CommentView);
        }
    }
}
