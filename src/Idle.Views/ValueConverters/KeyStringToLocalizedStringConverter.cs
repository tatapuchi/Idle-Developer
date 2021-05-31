using Idle.Resources.L10N;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Idle.Views.ValueConverters
{
    public class KeyStringToLocalizedStringConverter : ValueConverterBase
    {

        protected ILocalizationService LocalizationService = new LocalizationService();

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
