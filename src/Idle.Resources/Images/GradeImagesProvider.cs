using Idle.Common.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Idle.Resources.Images
{
	public class GradeImagesProvider : ImagesProviderBase
	{
		private static string _grades { get; } = _images + "Grades.";

		private static string _f { get; } = _grades + "F.png";
		private static string _d { get; } = _grades + "D.png";
		private static string _c { get; } = _grades + "C.png";
		private static string _b { get; } = _grades + "B.png";
		private static string _a { get; } = _grades + "A.png";
		private static string _s { get; } = _grades + "S.png";
		private static string _SP { get; } = _grades + "SP.png";
		private static string _SPP { get; } = _grades + "SPP.png";

		protected override string _fallback => _grades + "Fallback.png";

		private static readonly Dictionary<string, string> _resources = new Dictionary<Grade, string>()
		{
			[Grade.F] = _f,
			[Grade.D] = _d,
			[Grade.C] = _c,
			[Grade.B] = _b,
			[Grade.A] = _a,
			[Grade.S] = _s,
			[Grade.Sp] = _SP,
			[Grade.Spp] = _SPP,
		}.ToDictionary(resource => resource.Key.ToString(), resource => resource.Value);

		public override Stream GetStream(string resourceKey)
		{
			var resourceN = GetResourceNameOrFallBack(resourceKey);
			var stream = base.GetStream(resourceN);
			return stream;
		}

		private string GetResourceNameOrFallBack(string resourceKey)
		{
			if (_resources.TryGetValue(resourceKey, out var resourceName))
				return resourceName;

			return _fallback;
		}


	}
}
