using System;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client.Effects
{
    public class HtmlTextEffect : RoutingEffect
    {
        public HtmlTextEffect() : base("ShopAcross.HtmlTextEffect")
        {
        }

        public string HtmlText { get; set; }
    }
}