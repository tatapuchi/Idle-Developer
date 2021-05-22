using Idle.Logic.Common;
using Idle.Resources;
using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace Idle.Views.ValueConverters
{
    public class StringToImageSourceConverter : IValueConverter
    {
        private static ImagesProvider _imagesProvider = new ImagesProvider();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imagePath = (string)value;
            var imageSource = ImageSource.FromStream(() => _imagesProvider.GetStream(imagePath));
            return imageSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Data will not be travelling from target to source so I'll be leaving this as is
            throw new NotImplementedException();
        }
    }
}
