﻿using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Models.Models;
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
            IsActive = language.IsActive;
            _languageRepository = languagesRepository;
        }

        private LanguageItemViewModel()
        {
            // todo use canexecute changed // todo fix command, command canexecute is broken
            PurchaseLanguageCommand = new Command(_ => { IsActive = true; _languageRepository.UpdateAsync(GetModel()); } );
        }

        public ICommand PurchaseLanguageCommand { get; }

        public string Name => _language.Name;
        public string Description => _language.Description;
        public int XPCost => _language.XPCost;
        public string ImagePath => _language.ImagePath;

        private bool _isActive;
        public bool IsActive { get => _isActive; private set => TrySetProperty(ref _isActive, value); }

        public Language GetModel()
        {
            _language.IsActive = IsActive;
            return _language;
        }

        // make sure langauge is removed from observablecollection when its bought

    }
}
