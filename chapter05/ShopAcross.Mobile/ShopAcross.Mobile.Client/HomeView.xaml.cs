using System;
using System.Collections.Generic;
using ShopAcross.Mobile.Core;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var itemView = new ProductDetailsView();
            itemView.BindingContext = e.Item;
            Navigation.PushAsync(itemView);
        }

        private async void RecentItems_Clicked(object sender, EventArgs e)
        {
            //var recentProducts = new RecentProductsView();
                    await Shell.Current.GoToAsync("//recent");
            //Navigation.PushAsync(recentProducts);

        }
    }
}
