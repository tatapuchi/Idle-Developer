using Idle.Logic.Common;
using Idle.Logic.DI;
using Idle.Logic.Languages;
using Idle.Logic.Shop.LanguageMarket;
using System.Windows.Input;

namespace Idle.Logic
{
	public class MainViewModel : ViewModelBase
	{

		private readonly INavigationService _navigation;

		public MainViewModel(INavigationService navigation)
			: this()
		{
			_navigation = navigation;
		}

		private MainViewModel()
		{
			NavigateToLanguagesPageCommand = new AsyncCommand(async () => await _navigation.PushAsync<LanguagesViewModel>());
			NavigateToLanguageMarketCommand = new AsyncCommand(async () => await _navigation.PushAsync<LanguageMarketViewModel>());
		}


        public ICommand NavigateToLanguagesPageCommand { get; }
		public ICommand NavigateToLanguageMarketCommand { get; }

	}
}
