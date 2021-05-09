using Idle.Models.Fields.Languages;
using Idle.Resources.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.Resources
{
	internal struct TokenOf<T> { }

	public class ImagesProvider
	{
		private static Assembly _assembly { get; } = Assembly.GetExecutingAssembly();

		// Images are grouped into folders // Generic images are placed in this folder directly
		private static string _images { get; } = Constants.AssemblyName + ".Images.";
		private static string _fallback { get; } = _images + "Fallback.png";

		// All images which belong to the languages are below this line
		private static string _languages { get; } = _images + "Languages.";
		private static string _cSharp { get; } = _languages + "Csharp.png";
		private static string _kotlin { get; } = _languages + "Kotlin.png";

		// When someone adds another folder eg "Framworks" then follow the upper pattern. Example:
		// private static string _frameworks { get; } = _images + "Frameworks.";
		// private static string _cSharp { get; } = _frameworks + "SomeFramework.png";

		public string GetResourceNameOrFallBack<T>()
		{
			var resourceName = default(TokenOf<T>) switch
			{
				TokenOf<CSharp> _ => _cSharp,
				TokenOf<Kotlin> _ => _kotlin,
				_ => _fallback
			};

			return resourceName;
		}

		public Stream GetStream(string resourceName)
		{
			var stream = _assembly.GetManifestResourceStream(resourceName); 
			return stream;
		}

	}

	
}
