using Idle.Logic.Common;
using Idle.Resources;
using System.IO;

namespace Idle.Views.ValueConverters
{

	public class ImageStringToImageSourceConverter : StringToImageSourceConverterBase
	{
        protected override ImagesProviderBase ImagesProvider => new ImagesProvider();
	}

}
