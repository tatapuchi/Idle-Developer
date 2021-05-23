using Idle.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Idle.Logic.Common;
using System.Windows.Input;

namespace Idle.Logic.Languages
{
	public class LanguagesViewModel : ViewModelBase
	{
		private readonly LanguagesRepository _languageRepository;

		public LanguagesViewModel(LanguagesRepository languageRepository)
		{
			_languageRepository = languageRepository;
		}

		public RangeObservableCollection<LanguageViewModel> Languages { get; } = new RangeObservableCollection<LanguageViewModel>();

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
