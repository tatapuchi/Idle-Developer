using Idle.Common.Diagnostics;
using Idle.Logic.Languages;
using Idle.Views.Common;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Languages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LanguagesPage : ContentPage, IViewModel<LanguagesViewModel>
	{
		public LanguagesPage()
		{
			InitializeComponent();
		}

		public LanguagesViewModel ViewModel
		{
			get => (LanguagesViewModel)BindingContext;
			set => BindingContext = value;
		}

		protected async override void OnDisappearing()
		{
			try
			{
				await SaveAsync();
				base.OnDisappearing();
			}
			catch (Exception e)
			{
				var logger = ViewModel.Logger;
				logger.Log(LogLevel.Error, new LogMessage(e));
				#if DEBUG
					throw;
				#endif
			}
		}

		private Task SaveAsync() => ViewModel.SaveAsync();

	}
}
