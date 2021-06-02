using Idle.Resources.Images;

namespace Idle.Views.ValueConverters
{
	public class GradeStringToImageSourceConverter : StringToImageSourceConverterBase
    {
        protected override ImagesProviderBase ImagesProvider => new GradeImagesProvider();

    }
}
