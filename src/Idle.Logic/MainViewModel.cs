using Idle.Common.Diagnostics;
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
		private readonly ILogger _logger;

		public MainViewModel(INavigationService navigation, ILogger logger)
			: this()
		{
			_navigation = navigation;
			_logger = logger;
		}

		private MainViewModel()
		{
			NavigateToLanguagesPageCommand = new AsyncCommand(_logger, async () => await _navigation.PushAsync<LanguagesViewModel>());
			NavigateToLanguageMarketCommand = new AsyncCommand(_logger, async () => await _navigation.PushAsync<LanguageMarketViewModel>());
		}


        public ICommand NavigateToLanguagesPageCommand { get; }
		public ICommand NavigateToLanguageMarketCommand { get; }

	}
}
