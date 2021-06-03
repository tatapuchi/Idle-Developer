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
		// todo: think about minimizing the singleton access. Solutions:
		// 1: pass the logger to the ViewModelBase, which means we can access the logger in all views and viewmodels
		// 2: using factories and property or method injection
		// !! we dont want to inject the logger into the ctor of the view
		private readonly ILogger _logger = Logger.Instance;

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
				_logger.Log(LogLevel.Error, new LogMessage(e));
				#if DEBUG
					throw;
				#endif
			}
		}

		private Task SaveAsync() => ViewModel.SaveAsync();

	}
}
