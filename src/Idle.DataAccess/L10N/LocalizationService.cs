using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.DataAccess.L10N
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
