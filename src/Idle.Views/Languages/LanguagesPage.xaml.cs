using Idle.Logic.Languages;
using Idle.Views.Common;
using Idle.Views.ValueConverters;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views
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
			catch (Exception)
			{
				// todo use logging
				throw;
			}
		}

		private Task SaveAsync() => ViewModel.SaveAsync();

	}
}
