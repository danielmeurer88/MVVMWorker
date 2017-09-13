using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WorkerList
{
    public class StringPositiveNumberValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int i = -1;
            if (int.TryParse(value.ToString(),out i)) {

                if(i>=0)
                    return new ValidationResult(true, null);
                else
                    return new ValidationResult(false, "Eingabe ist keine positive Zahl");

            }
            else
            {

                return new ValidationResult(false, "Eingabe ist keine Ganze Zahl");
            }
        }
    }
}
