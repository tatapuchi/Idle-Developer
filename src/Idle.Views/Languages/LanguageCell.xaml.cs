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
		//private readonly Timer _progressTimer = new Timer();

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

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			if (ViewModel is null) return;
			//StartProgressAnimation(1, _duration, true);
			ProgressTo(_progressbarAnimationName, 1, _duration, Easing.Linear, true);
		}

		private async void GainProgressClicked(object sender, EventArgs e)
		{
			//progressBar.CancelAnimations();
			progressBar.AbortAnimation(_progressbarAnimationName);
			ViewModel.GainProgressCommand.Execute(null); 
			
			// todo resume the animation.
			double remainingProgress = 1 - ViewModel.Progress;
			double speed = 1 / (double)_duration;
            uint remainingDuration = (uint)(remainingProgress / speed);

			await ProgressTo(_progressbarAnimationName, 1, remainingDuration, Easing.Linear, false);
			progressBar.AbortAnimation(_progressbarAnimationName);
			await ProgressTo(_progressbarAnimationName, 1, _duration, Easing.Linear, true);
		}

		//private void StartProgressAnimation(uint progressTo, uint duration, bool isRecurring)
		//{
		//	progressBar.Animate(_recurringProgressAnimation,
		//		arg =>
		//		{
		//			var added = arg - ViewModel.Progress;
		//			ViewModel.Progress += (float)added;
		//			progressBar.Progress = ViewModel.Progress;
		//		}, progressTo, duration,
		//		Easing.Linear,
		//		(value, isFinished) =>
		//		{
		//			//if (isFinished && progressBar.Progress >= 1)
		//			//	progressBar.Progress = 0;
		//			//else
		//			//{
		//			//	progressBar.Progress = ViewModel.Progress;
		//			//}
		//		},
		//		() => isRecurring);
		//}

		private Task<bool> ProgressTo(string animationName, double value, uint length, Easing easing, bool isRecurring)
		{
			var tcs = new TaskCompletionSource<bool>();

			progressBar.Animate(animationName,
				d => ViewModel.Progress = (float)d, 
				ViewModel.Progress, value, 
				length: length, 
				easing: easing, 
				finished: (d, finished) => tcs.TrySetResult(finished),
				repeat: () => isRecurring);

			return tcs.Task;
		}
	}
}