using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Models.Fields;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Idle.Logic.Shop.Markets
{
    public class LanguageItemViewModel: ViewModelBase
    {
        private readonly Language _language;
        private readonly LanguagesRepository _languageRepository;

        public LanguageItemViewModel(Language language, LanguagesRepository languagesRepository)
            :this()
        {
            _language = language;
            Active = language.Active;
            _languageRepository = languagesRepository;
        }

        private LanguageItemViewModel()
        {
            PurchaseLanguageCommand = new Command(_ => { Active = true; _languageRepository.UpdateAsync(GetModel()); } );
        }

        public ICommand PurchaseLanguageCommand { get; }

        public string Name => _language.Name;
        public string Description => _language.Description;
        public int XPCost => _language.XPCost;
        public string ImagePath => _language.ImagePath;

        private bool _active;
        public bool Active { get => _active; private set => TrySetProperty(ref _active, value); }

        public Language GetModel()
        {
            _language.Active = Active;
            return _language;
        }

        // make sure langauge is removed from observablecollection when its bought

    }
}
