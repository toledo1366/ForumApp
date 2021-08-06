using Android.App;
using Android.OS;
using ForumApp.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace ForumApp.Droid.Views
{
    [Activity(Label = "PostsView", MainLauncher =true)]
    public class PostsView : MvxActivity<PostsViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PostsView);
        }
    }
}
