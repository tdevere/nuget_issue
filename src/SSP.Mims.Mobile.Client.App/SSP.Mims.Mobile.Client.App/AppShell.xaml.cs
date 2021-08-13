using SSP.Mims.Mobile.Client.App.ViewModels;
using SSP.Mims.Mobile.Client.App.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SSP.Mims.Mobile.Client.App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
