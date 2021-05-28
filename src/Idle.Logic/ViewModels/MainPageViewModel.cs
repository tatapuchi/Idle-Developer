using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Logic.Interfaces;
using Idle.Logic.Languages;
using Idle.Logic.Shop;
using Idle.Logic.Shop.Markets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Idle.Logic.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{

		private readonly INavigationService _navigation;

		public MainPageViewModel(INavigationService navigation)
			: this()
		{
			_navigation = navigation;
		}

		private MainPageViewModel()
		{
			NavigateToLanguagesPageCommand = new Command(async _ => await NavigateToLanguagesViewModelImpl());


			NavigateToLanguageMarketCommand = new Command(async _ => await NavigateToLanguageMarketModelImpl());
		}


        public ICommand NavigateToLanguagesPageCommand { get; }

		// temp
		public ICommand NavigateToLanguageMarketCommand { get; }

		private async Task<LanguagesViewModel> NavigateToLanguagesViewModelImpl()
		{
			try
			{
				return await _navigation.PushAsync<LanguagesViewModel>(true);
			}
			catch (Exception)
			{

				throw;
			}
		}


		private async Task<LanguageMarketViewModel> NavigateToLanguageMarketModelImpl()
		{
			try
			{
				return await _navigation.PushAsync<LanguageMarketViewModel>(true);
			}
			catch (Exception)
			{

				throw;
			}
		}

	}
}
