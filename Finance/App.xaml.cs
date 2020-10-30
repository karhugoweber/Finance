using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Finance.View;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Finance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            string androidAppSecret = "7a3693c1-e102-40b8-9c02-dc7693cbb61a";
           

            AppCenter.Start($"android={androidAppSecret}", typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
