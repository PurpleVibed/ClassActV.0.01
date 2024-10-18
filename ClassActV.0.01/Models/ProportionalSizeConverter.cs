using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace ClassActV._0._01.Converters
{
    public class ProportionalSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double parentSize && double.TryParse(parameter?.ToString(), out double proportion))
            {
                return parentSize * proportion;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
