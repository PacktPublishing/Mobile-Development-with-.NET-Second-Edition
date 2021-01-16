using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAcross.Mobile.Client.Extensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension<string>
    {
        public string Text { get; set; }

        public string ProvideValue(IServiceProvider serviceProvider)
        {
            switch (Text)
            {
                case "LblRequiredError":
                    return "This a required field";
                case "LblUsername":
                    return "Username";
                default:
                    return Text;
            }
        }

        object IMarkupExtension.ProvideValue(IServiceProvider
        serviceProvider)
        {
            return (this as IMarkupExtension<string>).ProvideValue(serviceProvider);
        }
    }

}
