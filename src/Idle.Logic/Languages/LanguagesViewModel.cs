using Idle.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Idle.Logic.Common;
using System.Windows.Input;
using Idle.Logic.Interfaces;

namespace Idle.Logic.Languages
{
	public class LanguagesViewModel : ViewModelBase
	{
		private readonly LanguagesRepository _languageRepository;
		private readonly IMainThreadService _mainThreadService;

		public Command<LanguageViewModel> XPCommand { get; set; }

		public LanguagesViewModel(LanguagesRepository languageRepository, IMainThreadService mainThreadService)
			: this()
		{
			_languageRepository = languageRepository;
			_mainThreadService = mainThreadService;
		}

		private LanguagesViewModel()
		{
			XPCommand = new Command<LanguageViewModel>(UpdateXP);
		}

		public RangeObservableCollection<LanguageViewModel> Languages { get; } = new RangeObservableCollection<LanguageViewModel>();

		public void UpdateXP<T>(T obj)
        {
			if(typeof(T) != typeof(LanguageViewModel)) { throw new ArgumentException("Command Parameter must be of type LanguageViewModel"); }
			var viewModel = obj as LanguageViewModel;
			viewModel.GainProgress();
        }

		public async Task LoadAsync()
		{
			var languages = await _languageRepository.GetAllAsync();
			var languageViewModels = languages.Select(lang => new LanguageViewModel(lang));

			Languages.AddRange(languageViewModels);

		}

		public Task<int> PushAsync()
		{
			var languages = Languages.Select(vm => vm._language);
			return _languageRepository.UpdateAllAsync(languages);
		}

	}

}
