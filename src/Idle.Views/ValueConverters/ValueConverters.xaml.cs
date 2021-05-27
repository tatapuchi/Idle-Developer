using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.ValueConverters
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValueConverters : ResourceDictionary
	{
		public ValueConverters()
		{
			InitializeComponent();
		}
	}
}