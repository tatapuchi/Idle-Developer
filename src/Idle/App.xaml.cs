
using Idle.DataAccess;
using Idle.DataAccess.Migrators;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Idle.Resources;
using Idle.Services;
using Idle.Logic.ViewModels;
using Idle.DataAccess.Repositories;
using Idle.Logic.Languages;
using Idle.Views;
using Idle.Views.Shop;
using Idle.Logic.Shop;
using Idle.Logic.Shop.Markets;
using Idle.Views.Shop.Markets;
using Idle.Logic;
using System.Threading.Tasks;

//Chewy-Regular font
//[assembly:ExportFont("Chewy-Regular.ttf", Alias = "Chewy")]

namespace Idle
{

    // todo app class should be in views assembly. resource dictionary cannot be used currently
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

        }

        public async Task InitilizeAsync() 
        {
            // "Idle.DataAccess"
            var languageImageProvider = new ImagesProvider();
            var languagesFactory = new LanguagesFactory(languageImageProvider);
            var languageMigrator = new LanguageMigrator(languagesFactory);
            await languageMigrator.MigrateAsync();

            var languagesRepository = new LanguagesRepository();

            // "Idle.Services"
            var navigation = new Lazy<INavigation>(() => Application.Current.MainPage.Navigation);
            var navigationService = new NavigationService(navigation);

            // "Idle.Logic" and "Idle.Views"
            var mainPage = SetBindingContext(new MainPage(), new MainPageViewModel(navigationService));

            navigationService.Register<MainPageViewModel>(() => mainPage);
            
            navigationService.Register<LanguagesViewModel>(() =>
                SetBindingContext(new LanguagesPage(), new LanguagesViewModel(languagesRepository)));

            navigationService.Register<LanguageMarketViewModel>(() =>
                SetBindingContext(new LanguageMarket(), new LanguageMarketViewModel(languagesRepository)));

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
