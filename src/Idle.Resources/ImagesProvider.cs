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




	public class ImagesProvider : ImagesProviderBase
	{
		// All images which belong to the languages are below this line
		private static string _languages { get; } = _images + "Languages.";
		private static string _cSharp { get; } = _languages + "Csharp.png";
		private static string _kotlin { get; } = _languages + "Kotlin.png";

		protected override string _fallback => _languages + "Fallback.png";

        // When someone adds another folder eg "Framworks" then follow the upper pattern. Example:
        // private static string _frameworks { get; } = _images + "Frameworks.";
        // private static string _cSharp { get; } = _frameworks + "SomeFramework.png";

        private static readonly Dictionary<Type, string> _resources = new Dictionary<Type, string>()
		{
			[typeof(CSharp)] = _cSharp,
			[typeof(Kotlin)] = _kotlin,
		};

		public string GetResourceNameOrFallBack<T>()
		{
			if (_resources.TryGetValue(typeof(T), out var resourceName))
				return resourceName;

			return _fallback;
		}
	}

	
}
