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
using Idle.Common.Diagnostics;

//Chewy-Regular font
//[assembly:ExportFont("Chewy-Regular.ttf", Alias = "Chewy")]

namespace Idle
{

	public partial class App : Application
    {
        private readonly ILogger _logger = Logger.Instance;


        public App()
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            InitializeComponent();

        }

		public async Task InitilizeAsync() 
        {
            // "Idle.Common"
            // ..

            // "Idle.DataAccess"
            var languagesFactory = new LanguagesFactory();
            var languageMigrator = new LanguageMigrator(languagesFactory, _logger);
            await languageMigrator.MigrateAsync();

            var languagesRepository = new LanguagesRepository();

            // "Idle.Services"
            var navigation = new Lazy<INavigation>(() => Application.Current.MainPage.Navigation);
            var navigationService = new NavigationService(navigation);

            // "Idle.Logic" and "Idle.Views"
            var mainPage = SetBindingContext(new MainPage(), new MainViewModel(navigationService, _logger));

            navigationService.Register<MainViewModel>(() => mainPage);
            
            navigationService.Register<LanguagesViewModel>(() =>
                SetBindingContext(new LanguagesPage(), new LanguagesViewModel(languagesRepository)));

            navigationService.Register<LanguageMarketViewModel>(() =>
                SetBindingContext(new LanguageMarketPage(), new LanguageMarketViewModel(languagesRepository, _logger)));

            // Idle.Views
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnSleep()
        {
   
        }

        protected override void OnResume()
        {
        }

        private static Page SetBindingContext(Page page, ViewModelBase vm)
        {
            page.BindingContext = vm;
            return page;
        }

        private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception)e.ExceptionObject;
            _logger.Log(LogLevel.Fatal, new LogMessage(exception));
        }


    }
}
