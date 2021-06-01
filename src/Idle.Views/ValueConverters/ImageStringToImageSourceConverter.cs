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

    }

}
