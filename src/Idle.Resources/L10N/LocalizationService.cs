using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Idle.Resources.L10N
{


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
