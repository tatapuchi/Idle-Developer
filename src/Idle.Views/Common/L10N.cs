using Idle.Resources.L10N;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Common
{
	// todo: move mainpage from Idle to Idle.Views then change this class to internal
	public class L10N : IMarkupExtension<string>
	{
		private static Localization _localization = new Localization();

		public string Key { get; set; }

		public string ProvideValue(IServiceProvider serviceProvider)
		{
			var value = _localization.GetString(Key);
			return value;
		}

		object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
		{
			var value = (this as IMarkupExtension<string>).ProvideValue(serviceProvider);
			return value;
		}
	}
}
