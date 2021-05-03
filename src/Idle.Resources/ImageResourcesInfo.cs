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
	public class LanguageImagesProvider
	{
		private const string Images = Constants.AssemblyName + "Images.";
		private const string languages = Images + "Languages.";

		private const string cSharp = languages + "Csharp.png";
		private const string kotlin = languages + "Kotlin.png";

		private const string fallback = Images + "Fallback.jpg";
		public Dictionary<Type, string> Resources { get; } = new Dictionary<Type, string>()
		{
			[typeof(CSharp)] = cSharp,
			[typeof(Kotlin)] = kotlin,
		};


		public string GetResourceNameOrFallback(Type type)
		{
			if(Resources.TryGetValue(type, out var result)) return result;
			return fallback;
		}

		public string GetResourcePathOrFallback(Type type)
		{
			if (Resources.TryGetValue(type, out var result)) { return ResourceToPath(result); }

            return ResourceToPath(fallback);
		}

		public string ResourceToPath(string resource)
        {
			string path;
			path = resource.Replace(".", "/");
			path = path.Replace("Idle.Resources.", string.Empty);
			path = Path.Combine(Paths.RootPath, path);

			return path;
		}

	}

	
}
