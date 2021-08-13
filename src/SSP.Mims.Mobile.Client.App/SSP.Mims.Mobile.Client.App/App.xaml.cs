using SSP.Mims.Mobile.Client.App.Services;
using SSP.Mims.Mobile.Client.App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSP.Mims.Mobile.Client.App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
