
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

        protected override void OnStart()
        {
            // "Idle.DataAccess"
            var languageImageProvider = new ImagesProvider();
            var languagesFactory = new LanguagesFactory(languageImageProvider);
            var languageMigrator = new LanguageMigrator(languagesFactory);
            languageMigrator.Migrate();

            var languagesRepository = new LanguagesRepository();

            // "Idle.Services"
            var navigation = new Lazy<INavigation>(() => Application.Current.MainPage.Navigation);
            var navigationService = new NavigationService(navigation);

            var mainPage = CreateMainPage(navigationService);
            var shopPage = CreateShopPage(navigationService);

            navigationService.Register<MainPageViewModel>(() => mainPage);

            navigationService.Register<LanguagesViewModel>(() =>
            {
                var page = new LanguagesPage();
                var vm = new LanguagesViewModel(languagesRepository);
                page.BindingContext = vm;

                return page;
            });

            navigationService.Register<ShopViewModel>(() => shopPage);

            navigationService.Register<LanguageMarketViewModel>(() => 
            {
                var page = new LanguageMarket();
                var vm = new LanguageMarketViewModel(languagesRepository);
                page.BindingContext = vm;

                return page;
            });

            // Idle.Views
            MainPage = new NavigationPage(mainPage);

        }

        private static MainPage CreateMainPage(NavigationService navigationService)
		{
            var page = new MainPage();
            var vm = new MainPageViewModel(navigationService);
            page.BindingContext = vm;

            return page;
        }

        private static ShopPage CreateShopPage(NavigationService navigationService)
        {
            var page = new ShopPage();
            var vm = new ShopViewModel(navigationService);
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
