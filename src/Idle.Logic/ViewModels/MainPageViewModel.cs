using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Logic.Interfaces;
using Idle.Logic.Languages;
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
		private readonly LanguagesRepository _languageRepository;

		public MainPageViewModel(INavigationService navigation, LanguagesRepository languageRepository)
			: this()
		{
			_navigation = navigation;
			_languageRepository = languageRepository;
		}

		private MainPageViewModel()
		{
			NavigateToLanguagesPageCommand = new Command(async _ => await NavigateToLanguagesViewModelImpl());
		}

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

		public ICommand NavigateToLanguagesPageCommand { get; }

		

	}
}
