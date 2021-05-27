using Idle.Logic.Shop.Markets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Shop.Markets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageMarket : ContentPage
    {
        public LanguageMarketViewModel viewModel = new LanguageMarketViewModel();
        public LanguageMarket()
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }
}