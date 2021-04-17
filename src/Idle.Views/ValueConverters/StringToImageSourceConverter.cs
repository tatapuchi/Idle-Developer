using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace Idle.Views.ValueConverters
{
    public class StringToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imagesAssembly = typeof(Idle.Framework.AssemblyInfo).GetTypeInfo().Assembly;
            var imageSource = ImageSource.FromResource((string) value, imagesAssembly);

            return imageSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Data will not be travelling from target to source so I'll be leaving this as is
            throw new NotImplementedException();
        }
    }
}
