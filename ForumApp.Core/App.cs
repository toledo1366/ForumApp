using System;
using ForumApp.Core.Interfaces;
using ForumApp.Core.Services;
using ForumApp.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace ForumApp.Core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IJsonPlaceHolderService, JsonPlaceHolderService>();

            RegisterCustomAppStart<AppStart>();
        }
    }
}
