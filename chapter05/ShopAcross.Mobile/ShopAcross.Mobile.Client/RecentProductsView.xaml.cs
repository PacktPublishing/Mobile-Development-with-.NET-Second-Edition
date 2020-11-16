using System;
using System.Collections.Generic;
using ShopAcross.Mobile.Core;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client
{
    public partial class RecentProductsView : CarouselPage
    {
        public RecentProductsView()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}
