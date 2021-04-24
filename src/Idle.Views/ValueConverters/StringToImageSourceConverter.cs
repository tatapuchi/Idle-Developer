using Idle.Logic.Languages;
using Idle.Resources;
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
        private static LanguageImagesProvider _languageImagesProvider = new LanguageImagesProvider();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //var imagesAssembly = typeof(Idle.Resources.AssemblyInfo).GetTypeInfo().Assembly;
            //var imageSource = ImageSource.FromResource((string) value, imagesAssembly);
            var vm = (LanguageViewModel)value;
            var model = vm.Model;
            var modelType = model.GetType();
            var imagePath = _languageImagesProvider.ResoucesAndPaths[modelType].ResourcePath;

            var imageSource = ImageSource.FromResource(imagePath);

            return imageSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Data will not be travelling from target to source so I'll be leaving this as is
            throw new NotImplementedException();
        }
    }
}
