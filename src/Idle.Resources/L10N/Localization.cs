using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.Resources.L10N
{
	public interface ILocalization
	{
		string GetString(string key);
		bool TrySetCulture(string cultureName);
	}

	public class Localization : ILocalization
	{
		private const string _neutral = "en";
		private static CultureInfo _usedCulture = new CultureInfo(_neutral);

		public string GetString(string key)
		{
			var result = LocalizationResource.ResourceManager.GetString(key, _usedCulture);
			return result;
		}

		public bool TrySetCulture(string cultureName)
		{
			if (!IsCultureSupported(cultureName)) return false;
			_usedCulture = new CultureInfo(cultureName);
			return true;
		}

		private static bool IsCultureSupported(string cultureName)
		{
			var supportedCultures = GetSupportedCultures();
			var isSupported = supportedCultures.Contains(cultureName);
			return isSupported;
		}

		// todo: when adding translations, you have to add the key also here
		private static IEnumerable<string> GetSupportedCultures()
		{
			yield return _neutral;
		} 

	
	}
}
