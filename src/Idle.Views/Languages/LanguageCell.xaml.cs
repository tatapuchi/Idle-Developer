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
		const string _progressbarAnimationName = "RecurringProgressAnimation";
		private uint _duration = 10000;

		public LanguageCell()
		{
			InitializeComponent();
		}

		public LanguageViewModel ViewModel 
		{
			get => (LanguageViewModel)BindingContext;
			set => BindingContext = value; 
		}

		protected async override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			if (ViewModel is null)
			{
				progressBar.AbortAnimation(_progressbarAnimationName);
				return;
			}
			await OnBindingContextChangedImpAsync();
		}

		private async Task OnBindingContextChangedImpAsync()
		{
			// the progress is saved in the db. this means we have to calculate the remaining duration.
			// after the progress bar loaded once. we need to use the infinite animation till we press a button
			var remainingDuration = CalculateRemainingDuration();
			await ProgressTo(_progressbarAnimationName, 1, remainingDuration, Easing.Linear, false);
			_ = ProgressTo(_progressbarAnimationName, 1, _duration, Easing.Linear, true); // this task runs infinite. we dont await it
		}

		private async void GainProgressClicked(object sender, EventArgs e)
		{
			// we have to stop the animation before we encrease the progress with a button. otherwise the progress will not change via a button
			progressBar.AbortAnimation(_progressbarAnimationName);
			ViewModel.GainProgressCommand.Execute(null);

			// when we encrease the progress with a button and resume the animation we have to calculate how fast the resuming animation has to be
			var remainingDuration = CalculateRemainingDuration();

			await ProgressTo(_progressbarAnimationName, 1, remainingDuration, Easing.Linear, false);
			progressBar.AbortAnimation(_progressbarAnimationName);

			// after the resuming animation finished we continue the standard repeating animation again
			await ProgressTo(_progressbarAnimationName, 1, _duration, Easing.Linear, true);
		}

		// this method was copy-pasted from the xamarin forms source code and modified
		// https://github.com/xamarin/Xamarin.Forms/blob/caab66bcf9614aca0c0805d560a34e176d196e17/Xamarin.Forms.Core/ProgressBar.cs
		private Task<bool> ProgressTo(string animationName, double value, uint length, Easing easing, bool isRecurring)
		{
			var tcs = new TaskCompletionSource<bool>();

			// this has to be either wrapped in a try catch or not awaited as a NRE occurs when navigating back off the page
			// or todo: stop the animation before navigating out of the page
			try
			{
				progressBar.Animate(animationName,
				d => ViewModel.Progress = (float)d,
				ViewModel.Progress, value,
				length: length,
				easing: easing,
				finished: (d, finished) => tcs.TrySetResult(finished),
				repeat: () => isRecurring);
			}
			catch (Exception)
			{
				tcs.TrySetResult(false);
			}

			return tcs.Task;
		}

		private uint CalculateRemainingDuration()
		{
			double remainingProgress = 1 - ViewModel.Progress;
			double speed = 1 / (double)_duration;
			uint remainingDuration = (uint)(remainingProgress / speed);

			return remainingDuration;
		}
	}
}