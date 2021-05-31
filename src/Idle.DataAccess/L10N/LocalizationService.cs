using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.Resources.L10N
{
	// todo: move everthing in this block to dataaccess as this contains logic of accessing data





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
