using Idle.Common.Diagnostics;
using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Models.Models;
using System.Windows.Input;

namespace Idle.Logic.Shop.LanguageMarket
{
	public class LanguageItemViewModel: ViewModelBase
    {
        private readonly Language _language;
        private readonly LanguagesRepository _languageRepository;
        public ILogger Logger { get; }

        public LanguageItemViewModel(Language language, LanguagesRepository languagesRepository, ILogger logger)
            :this()
        {
            _language = language;
            _languageRepository = languagesRepository;
            Logger = logger;
            IsActive = language.IsActive;
        }

        private LanguageItemViewModel()
        {
            PurchaseLanguageCommand = new AsyncCommand(Logger, async () => 
            { 
                IsActive = true; 
                await _languageRepository.UpdateAsync(GetModel());
            }, () => !IsActive);
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

    }
}
