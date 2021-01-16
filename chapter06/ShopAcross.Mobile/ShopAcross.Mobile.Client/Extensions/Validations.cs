using System;
using System.Linq;
using ShopAcross.Mobile.Client.Behaviors;
using ShopAcross.Mobile.Core;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client.Extensions
{
    public static class Validations
    {
        public static readonly BindableProperty ValidateRequiredProperty =
            BindableProperty.CreateAttached(
                "ValidateRequired",
                typeof(bool),
                typeof(RequiredValidationRule),
                false,
                propertyChanged: OnValidateRequiredChanged);

        public static bool GetValidateRequired(BindableObject view)
        {
            return (bool)view.GetValue(ValidateRequiredProperty);
        }

        public static void SetValidateRequired(BindableObject view,
        bool value)
        {
            view.SetValue(ValidateRequiredProperty, value);
        }

        private static void OnValidateRequiredChanged(
            BindableObject bindable,
            object oldValue,
            object newValue)
        {
            if (bindable is Entry entry)
            {
                if ((bool)newValue)
                {
                    entry.Behaviors.Add(new ValidationBehavior()
                    {
                        ValidationRule = new RequiredValidationRule()
                    });
                }
                else
                {
                    var behaviorToRemove = entry.Behaviors
                        .OfType<ValidationBehavior>()
                        .FirstOrDefault(
                            item => item.ValidationRule is
                            RequiredValidationRule);

                    if (behaviorToRemove != null)
                    {
                        entry.Behaviors.Remove(behaviorToRemove);
                    }
                }
            }
        }

    }

}
