using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.Resources.L10N
{
	internal class LocalizationResourceWrapper : LocalizationResource
	{
		private static string[] _possibleCultures { get; } = CultureInfo.GetCultures(CultureTypes.AllCultures)
				.Where(c => string.IsNullOrWhiteSpace(c.TwoLetterISOLanguageName))
				.Select(c => c.TwoLetterISOLanguageName)
				.ToArray();

		//protected string[] GetDefinedCultures()
		//{
		//	var path = typeof(LocalizationResource).Assembly.
		//}

	}


	public class LocalizationService
	{
		private static CultureInfo _usedCulture = new CultureInfo("en");
		
		


		public void SetCulture(string cultureName)
		{
			var culture = new CultureInfo(cultureName);

			

		}

		//public string GetString(string key, )
		//{
		//	var result = LocalizationResource.ResourceManager.
		//}
	}
}
