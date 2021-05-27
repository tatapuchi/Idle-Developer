using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Logic.Languages;
using Idle.Models.Fields;
using Idle.Models.Fields.Languages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idle.Logic.Shop.Markets
{
    public class LanguageMarketViewModel : ViewModelBase, IAsyncInit
    {
        private readonly LanguagesRepository _languageRepository;
        public RangeObservableCollection<LanguageItemViewModel> Items { get; set; } = new RangeObservableCollection<LanguageItemViewModel>();

        public LanguageMarketViewModel(LanguagesRepository languageRepository)
        {
            this._languageRepository = languageRepository;

            Items.Add(new LanguageItemViewModel(new CSharp()));
            Items.Add(new LanguageItemViewModel(new Java()));
            Items.Add(new LanguageItemViewModel(new Kotlin()));
        }

        public LanguageMarketViewModel()
        {
            Items.Add(new LanguageItemViewModel(new CSharp()));
            Items.Add(new LanguageItemViewModel(new Java()));
            Items.Add(new LanguageItemViewModel(new Kotlin()));
        }


        public async Task InitializeAsync()
        {
            var languages = await _languageRepository.GetAllInactiveLanguagesAsync();
            var languageItemViewModels = languages.Select(lang => CreateLanguageItemViewModel(lang));

            Items.AddRange(languageItemViewModels);
        }

        private LanguageItemViewModel CreateLanguageItemViewModel(Language lang)
        {
            var vm = new LanguageItemViewModel(lang);
            return vm;
        }

        public Task<int> SaveAsync()
        {
            var languages = Items.Select(vm => vm._language);
            return _languageRepository.UpdateAllAsync(languages);
        }

    }
}
