using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace zadanie2_konwerter.Converters
{
    internal class BoolToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return (bool)value? 8 : 3;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(bool))
                return System.Convert.ToInt32(value) < 3 ? false : true;
            if (targetType == typeof(int))
                return System.Convert.ToInt32(value) < 3 ? 0 : 1;
            if (targetType == typeof(string))
                return System.Convert.ToInt32(value) < 3 ? "that is false" : "that is true";
            throw new NotImplementedException();
            
        }
        //ten konwerter jest uniwersalny bo uwzględnia typ zwracany
    }
}
