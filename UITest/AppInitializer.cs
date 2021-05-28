using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    .ApkFile(@"C:\Users\chunxli\source\repos\github_repos\AppCenterDemo-XamarinForms\AppCenterDemo-XamarinForms.Android\bin\Debug\com.companyname.appcenterdemo_xamarinforms.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}