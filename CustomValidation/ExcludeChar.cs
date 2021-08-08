using System;
using System.ComponentModel.DataAnnotations;

namespace CustomDataAnnotaion.CustomValidation
{
    public class ExcludeChar : ValidationAttribute
    {
        private readonly string chars;
        public ExcludeChar(string chars)
        {
            this.chars = chars;

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    var stringValue = value.ToString();
                    if (stringValue.Contains(chars[i]))
                    {
                        var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                        return new ValidationResult(errorMessage);
                    }
                }

            }
            return ValidationResult.Success;
        }
    }
}