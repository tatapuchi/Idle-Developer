using Idle.Resources.Images;

namespace Idle.Views.ValueConverters
{
	public class GradeStringToImageSourceConverter : ObjectToImageSourceConverterBase
    {
        protected override ImagesProviderBase ImagesProvider => new GradeImagesProvider();

    }
}
