using System;
using System.Threading.Tasks;
using ForumApp.Core.ViewModels;
using MvvmCross.Exceptions;
using MvvmCross.ViewModels;

namespace ForumApp.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application, MvvmCross.Navigation.IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
			try
			{
				// You need to run Task sync otherwise code would continue before completing.
				var tcs = new TaskCompletionSource<bool>();
				var isAuthenticated = tcs.Task.Result;

				if (isAuthenticated)
				{
					//You need to Navigate sync so the screen is added to the root before continuing.
					return Task.Run(() => NavigationService.Navigate<PostsViewModel>().GetAwaiter().GetResult());
                }
                else
                {
					return null;
				}
			}
			catch (System.Exception exception)
			{
				throw exception.MvxWrap("Problem navigating to first ViewModel");
			}
		}
    }
}
