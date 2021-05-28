using System;
using System.Globalization;
using Xamarin.Forms;

namespace Idle.Views.ValueConverters
{
	public abstract class ValueConverterBase : IValueConverter
	{
        protected abstract object ConvertOverride(object value, Type targetType, object parameter, CultureInfo culture);
        protected abstract object ConvertBackOverride(object value, Type targetType, object parameter, CultureInfo culture);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = ConvertOverride(value, targetType, parameter, culture);
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = ConvertBackOverride(value, targetType, parameter, culture);
            return result;
        }
    }

    
}
