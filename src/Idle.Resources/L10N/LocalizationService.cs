using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.Resources.L10N
{
	public interface ILocalizationService
	{
		string GetString(string key);
		bool TrySetCulture(string cultureName);
	}

	public static class Localization
	{
		private const string _neutral = "en";
		internal static CultureInfo _usedCulture = new CultureInfo(_neutral);

		public static string GetString(string key)
		{
			var result = LocalizationResource.ResourceManager.GetString(key, _usedCulture);
			return result;
		}

		internal static bool IsCultureSupported(string cultureName)
		{
			var supportedCultures = GetSupportedCultures();
			var isSupported = supportedCultures.Contains(cultureName);
			return isSupported;
		}

		// todo: when adding translations, you have to add the key also here
		internal static IEnumerable<string> GetSupportedCultures()
		{
			yield return _neutral;
		}
	}

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
