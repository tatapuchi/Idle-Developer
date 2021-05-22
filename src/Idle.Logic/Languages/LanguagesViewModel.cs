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
using Idle.Models.Fields;

namespace Idle.Logic.Languages
{
	public class LanguagesViewModel : ViewModelBase, IAsyncInit
	{
		private readonly LanguagesRepository _languageRepository;
		private readonly IMainThreadService _mainThreadService;

		public Command<LanguageViewModel> XPCommand { get; set; }

		public LanguagesViewModel(LanguagesRepository languageRepository, IMainThreadService mainThreadService)
		{
			_languageRepository = languageRepository;
			_mainThreadService = mainThreadService;
		}

		public RangeObservableCollection<LanguageViewModel> Languages { get; } = new RangeObservableCollection<LanguageViewModel>();

		public async Task InitializeAsync()
		{
			var languages = await _languageRepository.GetAllAsync();
			var languageViewModels = languages.Select(lang => CreteLanguagesViewModel(lang));

			Languages.AddRange(languageViewModels);
		}

		private LanguageViewModel CreteLanguagesViewModel(Language lang)
		{
			var vm = new LanguageViewModel(lang, _mainThreadService);
			return vm;
		}

		public Task<int> PushAsync()
		{
			var languages = Languages.Select(vm => vm._language);
			return _languageRepository.UpdateAllAsync(languages);
		}

		
	}

}
