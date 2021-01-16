using System;
using System.Linq;
using ShopAcross.Mobile.Client.Effects;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client.Extensions
{
    public static class HtmlText
    {
        public static readonly BindableProperty IsHtmlProperty =
            BindableProperty.CreateAttached("IsHtml",
                typeof(bool), typeof(HtmlText), false,
                propertyChanged: OnHtmlPropertyChanged);

        public static bool GetIsHtml(BindableObject view)
            => (bool)view.GetValue(IsHtmlProperty);

        public static void SetIsHtml(BindableObject view, bool value)
            => view.SetValue(IsHtmlProperty, value);

        private static void OnHtmlPropertyChanged(
            BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null) { return; }

            if (newValue is bool isHtml && isHtml)
            {
                view.Effects.Add(new HtmlTextEffect());
            }
            else
            {
                var htmlEffect = view.Effects
                    .FirstOrDefault(e => e is HtmlTextEffect);

                if (htmlEffect != null)
                {
                    view.Effects.Remove(htmlEffect);
                }
            }

        }
    }
}
