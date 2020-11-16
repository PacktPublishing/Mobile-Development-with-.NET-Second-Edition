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
            var itemView = new ProductDeatilsView();
            itemView.BindingContext = e.Item;
            Navigation.PushAsync(itemView);
        }

private void RecentItems_Clicked(object sender, EventArgs e)
{
    var recentProducts = new RecentProductsView();
    Navigation.PushAsync(recentProducts);
}
    }
}
