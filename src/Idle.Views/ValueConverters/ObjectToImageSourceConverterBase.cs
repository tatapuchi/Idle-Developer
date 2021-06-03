using Idle.Resources.Images;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace Idle.Views.ValueConverters
{
	public abstract class ObjectToImageSourceConverterBase : ValueConverterBase
    {
        protected abstract ImagesProviderBase ImagesProvider { get; }

        protected override object ConvertOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // value is into value of emum
            string resourceKey;

            if (value is Enum e)
                resourceKey = e.ToString();
            else if (value is string s)
                resourceKey = s;
            else throw new NotImplementedException();

            var imageSource = ImageSource.FromStream(() => ImagesProvider.GetStream(resourceKey));
            return imageSource;
        }

        protected override object ConvertBackOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Data will not be travelling from target to source so I'll be leaving this as is
            throw new NotImplementedException();
        }

    }
}
