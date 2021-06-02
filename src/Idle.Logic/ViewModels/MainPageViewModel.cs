using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Logic.DI;
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
			NavigateToLanguagesPageCommand = new AsyncCommand(async () => await _navigation.PushAsync<LanguagesViewModel>());
			NavigateToLanguageMarketCommand = new AsyncCommand(async () => await _navigation.PushAsync<LanguageMarketViewModel>());
		}


        public ICommand NavigateToLanguagesPageCommand { get; }
		public ICommand NavigateToLanguageMarketCommand { get; }

	}
}
