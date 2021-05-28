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
	public abstract class ImagesProviderBase
	{
		// Images are grouped into folders // Generic images are placed in this folder directly
		protected static string _images { get; } = Constants.AssemblyName + ".Images.";
		protected static string _fallback { get; } = _images + "Fallback.png";
		private static Assembly _assembly { get; } = Assembly.GetExecutingAssembly();

		public virtual Stream GetStream(string resourceName)
		{
			var stream = _assembly.GetManifestResourceStream(resourceName);
			return stream;
		}
	}

	public class GradeImagesProvider : ImagesProviderBase
	{
		private static string _grades { get; } = _images + "Grades.";

		private static string _F { get; } = _grades + "F.png";
		private static string _D { get; } = _grades + "D.png";
		private static string _C { get; } = _grades + "C.png";
		private static string _B { get; } = _grades + "B.png";
		private static string _A { get; } = _grades + "A.png";
		private static string _S { get; } = _grades + "S.png";
		private static string _SP { get; } = _grades + "SP.png";
		private static string _SPP { get; } = _grades + "SPP.png";

		private static readonly Dictionary<string, string> _resources = new Dictionary<string, string>()
		{
			["F"] = _F,
			["D"] = _D,
			["C"] = _C,
			["B"] = _B,
			["A"] = _A,
			["S"] = _S,
			["S+"] = _SP,
			["S++"] = _SPP,
		};


		public override Stream GetStream(string resourceName)
		{
			var resourceN = GetResourceNameOrFallBack(resourceName);
			var stream = base.GetStream(resourceN);
			return stream;
		}

		public string GetResourceNameOrFallBack(string grade)
		{
			if (_resources.TryGetValue(grade, out var resourceName))
				return resourceName;

			return _fallback;
		}

	}

	public class ImagesProvider : ImagesProviderBase
	{
		// All images which belong to the languages are below this line
		private static string _languages { get; } = _images + "Languages.";
		private static string _cSharp { get; } = _languages + "Csharp.png";
		private static string _kotlin { get; } = _languages + "Kotlin.png";

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
