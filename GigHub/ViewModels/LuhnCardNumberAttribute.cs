using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class LuhnCardNumberAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessage = "Incorrect credit card ";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (new LuhnAlgorithmRefactor().IsValid(value))
                return ValidationResult.Success;
            return new ValidationResult(ErrorMessage ??
                                            DefaultErrorMessage);
        }
    }
}