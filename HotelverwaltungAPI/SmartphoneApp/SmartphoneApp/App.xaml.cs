using SmartphoneApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartphoneApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WelcomePageView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
