﻿using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Logic.Languages;
using Idle.Models.Models;
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
        public RangeObservableCollection<LanguageItemViewModel> Languages { get; } = new RangeObservableCollection<LanguageItemViewModel>();

        public LanguageMarketViewModel(LanguagesRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
        public async Task InitializeAsync()
        {
            var languages = await _languageRepository.GetAllAsync();
            var languageItemViewModels = languages.Select(lang => CreateLanguageItemViewModel(lang));

            Languages.AddRange(languageItemViewModels);
        }

        private LanguageItemViewModel CreateLanguageItemViewModel(Language lang)
        {
            var vm = new LanguageItemViewModel(lang, _languageRepository);
            return vm;
        }

    }
}
