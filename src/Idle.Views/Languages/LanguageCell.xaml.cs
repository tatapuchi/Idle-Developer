using Idle.Logic.Languages;
using Idle.Views.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Languages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LanguageCell : Frame, IViewModel<LanguageViewModel>
	{
		private readonly Timer _progressTimer = new Timer();


		public LanguageCell()
		{
			InitializeComponent();

			
		}

		public LanguageViewModel ViewModel 
		{
			get => (LanguageViewModel)BindingContext;
			set => BindingContext = value; 
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			if(ViewModel is null)
			{
				_progressTimer.Elapsed -= OnProgressTimerElapsed;
				_progressTimer.Stop();
			}
			else
			{
				_progressTimer.Interval = 11000;
				_progressTimer.Elapsed += OnProgressTimerElapsed;
				_progressTimer.Start();
			}
			
		}

		// todo async void
		private async void OnProgressTimerElapsed(object sender, ElapsedEventArgs e)
		{
			await Device.InvokeOnMainThreadAsync(async () =>
			{
				await progressBar.ProgressTo(1, 10000, Easing.Linear);
				await progressBar.ProgressTo(0, 0, Easing.Linear);
			});
		}

	}
}