using Idle.Views.Common;
using Idle.Views.Shop.Markets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Views.Shop
{
	public class FlyoutPageItem
	{
		public string Title { get; set; }

		public string IconSource { get; set; }

		public Type TargetType { get; set; }

		public Type ViewModelType { get; set; }
	}
}
