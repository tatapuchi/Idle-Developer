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
        internal readonly Language _language;

        public LanguageItemViewModel(Language language)
        {
            this._language = language;
            PurchaseLanguageCommand = new Command(_ => _language.Active = true); ;
        }

        public ICommand PurchaseLanguageCommand { get; }

        public string Name => _language.Name;
        public string Description => _language.Description;
        public int XPCost => _language.XPCost;
        public string ImagePath => _language.ImagePath;
         
        // make sure langauge is removed from observablecollection when its bought

    }
}
