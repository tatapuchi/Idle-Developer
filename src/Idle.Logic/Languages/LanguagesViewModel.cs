using Idle.DataAccess.Repositories;
using System.Threading.Tasks;
using System.Linq;
using Idle.Logic.Common;
using Idle.Models.Models;
using Idle.Common.Diagnostics;

namespace Idle.Logic.Languages
{
	public class LanguagesViewModel : ViewModelBase, IAsyncInit
	{
		private readonly LanguagesRepository _languageRepository;
		public ILogger Logger { get; }

		public LanguagesViewModel(LanguagesRepository languageRepository, ILogger logger)
		{
			_languageRepository = languageRepository;
			Logger = logger;
		}

		public RangeObservableCollection<LanguageViewModel> Languages { get; } = new RangeObservableCollection<LanguageViewModel>();

		public async Task InitializeAsync()
		{
			var languages = await _languageRepository.GetAllActiveLanguagesAsync();
			var languageViewModels = languages.Select(lang => CreateLanguageViewModel(lang));

			Languages.AddRange(languageViewModels);
		}

		private LanguageViewModel CreateLanguageViewModel(Language lang)
		{
			var vm = new LanguageViewModel(lang);
			return vm;
		}

		public Task<int> SaveAsync()
		{
			var languages = Languages.Select(vm => vm.GetModel());
			return _languageRepository.UpdateAllAsync(languages);
		}

		
	}

}
