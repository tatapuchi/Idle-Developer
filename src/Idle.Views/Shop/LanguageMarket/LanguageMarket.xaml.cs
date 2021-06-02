using Idle.Logic.Shop.LanguageMarket;
using Idle.Views.Common;
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
    }
}