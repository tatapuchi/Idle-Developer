using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Logic.Interfaces;
using Idle.Logic.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Idle.Logic.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{

		private readonly INavigationService _navigation;
		private readonly LanguageRepository _languageRepository;

		public MainPageViewModel(INavigationService navigation, LanguageRepository languageRepository)
			: this()
		{
			_navigation = navigation;
			_languageRepository = languageRepository;
		}

		private MainPageViewModel()
		{
			NavigateToLanguagesPageCommand = new Command(async _ => 
			{
				var vm = await _navigation.PushAsync<LanguagesViewModel>(true);
				await vm.LoadAsync();
			});
		}

		public ICommand NavigateToLanguagesPageCommand { get; }

	}
}
