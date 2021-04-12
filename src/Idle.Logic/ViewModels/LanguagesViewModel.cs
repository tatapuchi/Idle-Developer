using Idle.DataAccess.Repositories;
using Idle.Logic.ModelViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Idle.Logic.Common;

namespace Idle.Logic.ViewModels
{
	public class LanguagesViewModel : BaseViewModel
	{
		private readonly LanguageRepository _languageRepository;

		public LanguagesViewModel(LanguageRepository languageRepository)
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
	}
}
