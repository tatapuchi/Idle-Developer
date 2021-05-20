
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

//Chewy-Regular font
//[assembly:ExportFont("Chewy-Regular.ttf", Alias = "Chewy")]

namespace Idle
{
    public partial class App : Application
    {

        //Number of times opened
        public static int timesopened;
        public App()
        {
            InitializeComponent();

        }

        protected override void OnStart()
        {
            var languageImageProvider = new ImagesProvider();
            var languagesFactory = new LanguagesFactory(languageImageProvider);

            var languageMigrator = new LanguageMigrator(languagesFactory);
            languageMigrator.Migrate();

            var languagesRepository = new LanguageRepository();

            var naviation = new Lazy<INavigation>(() => Application.Current.MainPage.Navigation);
            var navigationService = new NavigationService(naviation);

            navigationService.Register<MainPageViewModel>(() => 
            {
                var page = CreateMainPage(navigationService, languagesRepository);
                return page;
            });

            navigationService.Register<LanguagesViewModel>(() =>
            {
                var page = new LanguagesPage();
                var vm = new LanguagesViewModel(languagesRepository);
                page.BindingContext = vm;

                return page;
            });

            var mainPage = CreateMainPage(navigationService, languagesRepository);

            MainPage = new NavigationPage(mainPage);

        }

        private MainPage CreateMainPage(NavigationService navigationService, LanguageRepository languagesRepository)
		{
            var page = new MainPage();
            var vm = new MainPageViewModel(navigationService, languagesRepository);
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
