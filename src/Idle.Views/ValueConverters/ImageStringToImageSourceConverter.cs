using Idle.Resources.Images;

namespace Idle.Views.ValueConverters
{

	public class ImageStringToImageSourceConverter : ObjectToImageSourceConverterBase
	{
        protected override ImagesProviderBase ImagesProvider => new ImagesProvider();

    }

}
