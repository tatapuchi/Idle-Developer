using System.IO;

namespace Idle.Resources.Images
{
	public class ImagesProvider : ImagesProviderBase
	{
		private static string _languages { get; } = _images + "Languages.";
		protected override string _fallback => _languages + "Fallback.png";

		public override Stream GetStream(string resourceKey)
		{
			var stream = base.GetStream(resourceKey);
			if (stream is null)
				stream = base.GetStream(_fallback);

			return stream;
		}
	}

	
}
