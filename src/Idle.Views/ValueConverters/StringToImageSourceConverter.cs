using Idle.Logic.Common;
using Idle.Resources;
using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace Idle.Views.ValueConverters
{
    public abstract class StringToImageSourceConverterBase : IValueConverter
    {
        protected abstract ImagesProviderBase ImagesProvider { get; }

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

        protected virtual object ConvertOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imagePath = (string)value;
            var imageSource = ImageSource.FromStream(() => ImagesProvider.GetStream(imagePath));
            return imageSource;
        }

        protected virtual object ConvertBackOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Data will not be travelling from target to source so I'll be leaving this as is
            throw new NotImplementedException();
        }


    }

	public class StringToImageSourceConverter : StringToImageSourceConverterBase
	{
        protected override ImagesProviderBase ImagesProvider => new ImagesProvider();
	}
}
