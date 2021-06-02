using System;
using System.ComponentModel.DataAnnotations;

namespace Facturas.Utils
{
    public class IsPositive : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is null)
            {
                return false;
            }

            return Convert.ToInt32(value) > 0 ? true : false;
        }
    }
}
