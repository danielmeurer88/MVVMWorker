using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WorkerList
{
    class DegreeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Degree d = (Degree)value;
            if (d == Degree.None)
                return "keinen";
            if (d == Degree.Doctorate)
                return "Doktor";

            return d.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Degree.NotFound;
        }
    }
}
