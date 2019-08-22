using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NortWind.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NortWind
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CategView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
