using System.IO;

namespace Idle.Resources.Images
{
	public abstract class ImagesProviderBase
	{
		protected static string _images { get; } = Constants.AssemblyName + ".Images.";
		protected abstract string _fallback { get; }

		private static System.Reflection.Assembly _assembly { get; } = Constants.ResourcesAssembly;

		public virtual Stream GetStream(string resourceName)
		{
			var stream = _assembly.GetManifestResourceStream(resourceName);
			return stream;
		}
	}
}
