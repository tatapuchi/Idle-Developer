using Idle.Logic.Shop.Markets;
using Idle.Views.Common;
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
    public partial class LanguageMarket : ContentPage, IViewModel<LanguageMarketViewModel>
    {
        public LanguageMarket()
        {
            InitializeComponent();
        }

        public LanguageMarketViewModel ViewModel
        {
            get => (LanguageMarketViewModel)BindingContext;
            set => BindingContext = value;
        }

        protected async override void OnDisappearing()
        {
            try
            {
                await SaveAsync();
                base.OnDisappearing();
            }
            catch (Exception)
            {
                // todo use logging
                throw;
            }
        }

        private Task SaveAsync() => ViewModel.SaveAsync();
    }
}