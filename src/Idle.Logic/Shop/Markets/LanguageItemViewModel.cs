using Idle.Models.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Logic.Shop.Markets
{
    public class LanguageItemViewModel: ViewModelBase
    {
        internal readonly Language _language;

        public LanguageItemViewModel(Language language)
        {
            this._language = language;
        }

        public string Name => _language.Name;
        public string Description => _language.Description;
        public int XPCost => _language.XPCost;
        public string ImagePath => _language.ImagePath;
    }
}
