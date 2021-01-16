using System;
using ShopAcross.Mobile.Core;
using Xamarin.Forms;

namespace ShopAcross.Mobile.Client.Behaviors
{
    public class ValidationBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty ValidationRuleProperty =
         BindableProperty.CreateAttached("ValidationRule", typeof(IValidationRule<string>), typeof(ValidationBehavior), null);


        public static readonly BindableProperty HasErrorProperty =
                 BindableProperty.CreateAttached("HasError", typeof(bool), typeof(ValidationBehavior), false, BindingMode.TwoWay);

        public IValidationRule<string> ValidationRule
        {
            get { return this.GetValue(ValidationRuleProperty) as IValidationRule<string>; }
            set { this.SetValue(ValidationRuleProperty, value); }
        }

        public bool HasError
        {
            get { return (bool)GetValue(HasErrorProperty); }
            set { SetValue(HasErrorProperty, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += ValidateField;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= ValidateField;
        }

        private void ValidateField(object sender, TextChangedEventArgs args)
        {
            if (sender is Entry entry && ValidationRule != null)
            {
                if (!ValidationRule.Validate(args.NewTextValue))
                {
                    entry.BackgroundColor = Color.Crimson;
                    HasError = true;
                }
                else
                {
                    entry.BackgroundColor = Color.White;
                    HasError = false;
                }
            }
        }
    }
}
