using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Idle.DataAccess.Images
{
	public abstract class ImagesProviderBase
	{
		// Images are grouped into folders // Generic images are placed in this folder directly
		protected static string _images { get; } = Constants.AssemblyName + ".Images.";
		protected abstract string _fallback { get; }
		public virtual string fallback { get; }
		private static Assembly _assembly { get; } = Constants.ResourcesAssembly;

		public virtual Stream GetStream(string resourceName)
		{
			var stream = _assembly.GetManifestResourceStream(resourceName);
			return stream;
		}
	}
}
