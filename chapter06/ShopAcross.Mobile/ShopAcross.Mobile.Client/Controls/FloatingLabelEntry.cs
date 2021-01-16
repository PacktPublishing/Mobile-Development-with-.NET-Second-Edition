using System;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client.Controls
{
    public class FloatingLabelEntry : Entry
    {
        public static readonly BindableProperty ErrorMessageProperty =
            BindableProperty.CreateAttached("ErrorMessage", typeof(string), typeof(FloatingLabelEntry), string.Empty);

        public static readonly BindableProperty HasErrorProperty =
            BindableProperty.CreateAttached("HasError", typeof(bool), typeof(FloatingLabelEntry), false);

        public string ErrorMessage
        {
            get
            {
                return (string)GetValue(ErrorMessageProperty);
            }
            set
            {
                SetValue(ErrorMessageProperty, value);
            }
        }

        public bool HasError
        {
            get
            {
                return (bool)GetValue(HasErrorProperty);
            }
            set
            {
                SetValue(HasErrorProperty, value);
            }
        }
    }

}
