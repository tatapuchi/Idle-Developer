using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.L10N
{
	public interface ILocalizationService
	{
		string GetString(string key);
		bool TrySetCulture(string cultureName);
	}
}
