using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Languages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LanguageCell : Frame
	{
		public LanguageCell()
		{
			InitializeComponent();
		}
	}
}