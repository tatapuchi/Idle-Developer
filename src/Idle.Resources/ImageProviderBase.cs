using Idle.Resources.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Idle.Resources
{
	public abstract class ImagesProviderBase
	{
		// Images are grouped into folders // Generic images are placed in this folder directly
		protected static string _images { get; } = Constants.AssemblyName + ".Images.";
		protected abstract string _fallback { get; }
		private static Assembly _assembly { get; } = Assembly.GetExecutingAssembly();

		public virtual Stream GetStream(string resourceName)
		{
			var stream = _assembly.GetManifestResourceStream(resourceName);
			return stream;
		}
	}
}
