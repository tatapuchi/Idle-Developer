using Idle.Logic.Languages;
using Idle.Models.Fields;
using Idle.Models.Fields.Languages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Idle.Logic.Shop.Markets
{
    public class LanguageMarketViewModel : ViewModelBase
    {

        public ObservableCollection<LanguageItemViewModel> Items { get; set; } = new ObservableCollection<LanguageItemViewModel>();

        public LanguageMarketViewModel()
        {
            Items.Add(new LanguageItemViewModel(new CSharp()));
            Items.Add(new LanguageItemViewModel(new Java()));
            Items.Add(new LanguageItemViewModel(new Kotlin()));
        }
    }
}
