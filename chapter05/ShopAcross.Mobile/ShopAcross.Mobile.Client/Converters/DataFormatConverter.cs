using System;

using Xamarin.Forms;

namespace ShopAcross.Mobile.Client.Converters
{
    public class DataFormatConverter : ContentPage
    {
        public DataFormatConverter()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

