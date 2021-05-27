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

        public ObservableCollection<LanguageViewModel> Items { get; set; } = new ObservableCollection<LanguageViewModel>();

        public LanguageMarketViewModel()
        {
            Items.Add(new LanguageViewModel(new CSharp()));
            Items.Add(new LanguageViewModel(new Java()));
            Items.Add(new LanguageViewModel(new Kotlin()));
        }
    }
}
