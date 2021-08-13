using SSP.Mims.Mobile.Client.App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SSP.Mims.Mobile.Client.App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}