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
			var path = typeof(LocalizationResource);
			return null;
		}

	}
}
