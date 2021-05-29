using System.Globalization;
using System.Linq;

namespace Idle.Resources.L10N
{
	internal class LocalizationResourceWrapper : LocalizationResource
	{
		private static string[] _possibleCultures { get; } = CultureInfo.GetCultures(CultureTypes.AllCultures)
				.Where(c => string.IsNullOrWhiteSpace(c.TwoLetterISOLanguageName))
				.Select(c => c.TwoLetterISOLanguageName)
				.ToArray();

		internal protected string[] GetSupportedCultures()
		{
			var type = typeof(LocalizationResource);
			var assembly = type.Assembly;
			var ns = type.Namespace;

			const string resx = ".resx";

			var resxFiles = assembly.GetTypes()
				.Where(t => !t.IsClass && t.Namespace == ns && t.Name.EndsWith(resx))
				.Select(t => t.Name);
			
			return null;
		}

	}
}
