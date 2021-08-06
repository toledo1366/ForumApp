using System;
using Microsoft.Extensions.Logging;
using MvvmCross.IoC;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace ForumApp.Droid
{
    public class Setup:MvxAndroidSetup
    {
        protected override IMvxApplication CreateApp(IMvxIoCProvider iocProvider)
        {
            return new Core.App();
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            return null;
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            return null;
        }

    }
}
