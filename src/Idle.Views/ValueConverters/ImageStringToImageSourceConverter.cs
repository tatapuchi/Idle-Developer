using Idle.Resources.Images;

namespace Idle.Views.ValueConverters
{

	public class ImageStringToImageSourceConverter : StringToImageSourceConverterBase
	{
        protected override ImagesProviderBase ImagesProvider => new ImagesProvider();

    }

}
