using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.Resources.Images
{
	public class ImagesProvider : ImagesProviderBase
	{
		private static string _languages { get; } = _images + "Languages.";
		protected override string _fallback => _languages + "Fallback.png";

		public override Stream GetStream(string resourceName)
		{
			var stream = base.GetStream(resourceName);
			if (stream is null)
				stream = base.GetStream(_fallback);

			return stream;
		}
	}

	
}
