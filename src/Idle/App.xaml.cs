using Idle.DataAccess.Migrators;
using System;
using Xamarin.Forms;
using Idle.Services;
using Idle.DataAccess.Repositories;
using Idle.Logic.Languages;
using Idle.Views;
using Idle.Views.Shop.Markets;
using Idle.Logic;
using System.Threading.Tasks;
using Idle.Logic.Common;
using Idle.Logic.Shop.LanguageMarket;
using Idle.Views.Languages;

//Chewy-Regular font
//[assembly:ExportFont("Chewy-Regular.ttf", Alias = "Chewy")]

namespace Idle
{

	public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

        }

        public async Task InitilizeAsync() 
        {
            // "Idle.DataAccess"
            var languagesFactory = new LanguagesFactory();
            var languageMigrator = new LanguageMigrator(languagesFactory);
            await languageMigrator.MigrateAsync();

            var languagesRepository = new LanguagesRepository();

            // "Idle.Services"
            var navigation = new Lazy<INavigation>(() => Application.Current.MainPage.Navigation);
            var navigationService = new NavigationService(navigation);

            // "Idle.Logic" and "Idle.Views"
            var mainPage = SetBindingContext(new MainPage(), new MainViewModel(navigationService));

            navigationService.Register<MainViewModel>(() => mainPage);
            
            navigationService.Register<LanguagesViewModel>(() =>
                SetBindingContext(new LanguagesPage(), new LanguagesViewModel(languagesRepository)));

            navigationService.Register<LanguageMarketViewModel>(() =>
                SetBindingContext(new LanguageMarketPage(), new LanguageMarketViewModel(languagesRepository)));

            // Idle.Views
            MainPage = new NavigationPage(mainPage);
        }

        private static Page SetBindingContext(Page page, ViewModelBase vm)
		{
            page.BindingContext = vm;
            return page;
		}

        protected override void OnSleep()
        {
   
        }

        protected override void OnResume()
        {
        }

      
    }
}
