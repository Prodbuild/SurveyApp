using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EnrollmentWorkflow.Helpers.DataAnotationsExtensions
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ValidInteger : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || value.ToString().Length == 0)
            { return ValidationResult.Success; }
            int i;

            return !int.TryParse(value.ToString(), out i) ? new ValidationResult(ErrorMessage) : ValidationResult.Success;
        }
    }
}