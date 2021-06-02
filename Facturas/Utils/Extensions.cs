using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Facturas.Utils
{
    public static class Extensions
    {
        public static List<ValidationResult> ValidateModel(Object model)
        {
            ValidationContext context = new ValidationContext(model, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(model, context, validationResults, true);
            if (!valid)
            {
                return validationResults;
            }

            return new List<ValidationResult>();
        }
    }
}
