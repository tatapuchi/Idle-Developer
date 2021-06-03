using System.IO;

namespace Idle.Resources.Images
{
	public abstract class ImagesProviderBase
	{
		protected static string _images { get; } = Constants.AssemblyName + ".Images.";
		protected abstract string _fallback { get; }

		private static System.Reflection.Assembly _assembly { get; } = Constants.ResourcesAssembly;

		public virtual Stream GetStream(string resourceKey)
		{
			var stream = _assembly.GetManifestResourceStream(resourceKey);
			return stream;
		}
	}
}
