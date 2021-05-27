
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

        protected async override void OnStart()
        {

			try
			{
                await OnStartImplAsync();
			}
			catch (Exception)
			{

				throw;
			}
        }

        private async Task OnStartImplAsync() 
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

            var mainPage = CreateMainPage(navigationService);

            navigationService.Register<MainPageViewModel>(() => mainPage);

            navigationService.Register<LanguagesViewModel>(() =>
            {
                var page = new LanguagesPage();
                var vm = new LanguagesViewModel(languagesRepository);
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

       

        protected override void OnSleep()
        {
   
        }

        protected override void OnResume()
        {
        }

      
    }
}
