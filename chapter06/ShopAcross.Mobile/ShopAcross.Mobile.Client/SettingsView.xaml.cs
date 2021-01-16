using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShopAcross.Mobile.Client
{
    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
        }

private async void Button_Clicked(object sender, EventArgs e)
{
    await Shell.Current.GoToAsync("//home");
}
    }
}
