using Idle.DataAccess.Images;
using Idle.Logic.Common;
using Idle.Resources;
using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace Idle.Views.ValueConverters
{

	public class ImageStringToImageSourceConverter : StringToImageSourceConverterBase
	{
        protected override ImagesProviderBase ImagesProvider => new ImagesProvider();

        protected override object ConvertOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imagePath = (string)value;
            var stream = ImagesProvider.GetStream(imagePath);
            if (stream == null)
            {
                var fallbackImageSource = ImageSource.FromStream(() => ImagesProvider.GetStream(ImagesProvider.fallback));
                return fallbackImageSource;
            }
            var imageSource = ImageSource.FromStream(() => stream);
            return imageSource;
        }
    }

}
