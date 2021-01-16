using System;
namespace ShopAcross.Mobile.Core
{
    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }
        bool Validate(T value);
    }

    public class RequiredValidationRule : IValidationRule<string>
    {
        public string ValidationMessage { get; set; } = "This field is a required field";
     
     public bool Validate(string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
