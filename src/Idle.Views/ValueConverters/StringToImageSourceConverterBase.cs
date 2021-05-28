using Idle.Resources;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace Idle.Views.ValueConverters
{
	public abstract class StringToImageSourceConverterBase : ValueConverterBase
    {
        protected abstract ImagesProviderBase ImagesProvider { get; }

        protected override object ConvertOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imagePath = (string)value;
            var imageSource = ImageSource.FromStream(() => ImagesProvider.GetStream(imagePath));
            return imageSource;
        }

        protected override object ConvertBackOverride(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Data will not be travelling from target to source so I'll be leaving this as is
            throw new NotImplementedException();
        }


    }

    // todo
    public class GradeStringToImageSourceConverter : StringToImageSourceConverterBase
    {
        protected override ImagesProviderBase ImagesProvider => new GradeImagesProvider();

        //protected override object ConvertOverride(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    var imagePath = ImagesProvider.GetResourceNameOrFallBack((string)value);
        //    var imageSource = ImageSource.FromStream(() => ImagesProvider.GetStream(imagePath));
        //    return imageSource;
        //}
    }

}
