using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Idle.Resources
{
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

		protected override string _fallback => _grades + "Fallback.png";

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

		private string GetResourceNameOrFallBack(string grade)
		{
			if (_resources.TryGetValue(grade, out var resourceName))
				return resourceName;

			return _fallback;
		}


	}
}
