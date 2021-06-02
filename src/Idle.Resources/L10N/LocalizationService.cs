using System.Globalization;

namespace Idle.Resources.L10N
{
	public class LocalizationService : ILocalizationService
	{
		public string GetString(string key)
		{
			var result = Localization.GetString(key);
			return result;
		}

		public bool TrySetCulture(string cultureName)
		{
			if (!Localization.IsCultureSupported(cultureName)) return false;
			Localization._usedCulture = new CultureInfo(cultureName);
			return true;
		}

	}
}
