using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WorkerList
{
    public class NoEmptyStringValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if( string.IsNullOrEmpty(value.ToString()) ) {
                return new ValidationResult(false, "Eingabefeld darf nicht leer sein");
            }
            return new ValidationResult(true, null);

        }
    }
}
