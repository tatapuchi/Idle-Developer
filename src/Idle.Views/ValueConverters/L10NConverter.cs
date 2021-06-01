using Idle.Resources.L10N;
using System;
using System.Globalization;

namespace Idle.Views.ValueConverters
{
	public class L10NConverter : ValueConverterBase
    {

        private static ILocalizationService LocalizationService = new LocalizationService();

        protected override object ConvertOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var localizedString = LocalizationService.GetString((string)value);
            return localizedString;
        }
        protected override object ConvertBackOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Data is not travelling to source
            throw new NotImplementedException();
        }

    }
}
