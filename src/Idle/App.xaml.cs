
using Idle.DataAccess;
using Idle.DataAccess.Migrators;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Idle.Resources;

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
            var languageImageProvider = new LanguageImagesProvider();
            var languagesFactory = new LanguagesFactory(languageImageProvider);

            var languageMigrator = new LanguageMigrator(languagesFactory);
            languageMigrator.Migrate();

            var directoryMigrator = new DirectoryMigrator();
            var imagesMigrator = new ImagesMigrator(languageImageProvider);

            var resourceAccessMigrator = new ResourcesMigarator(directoryMigrator, imagesMigrator);
            resourceAccessMigrator.Migrate();

            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnSleep()
        {
   
        }

        protected override void OnResume()
        {
        }

      
    }
}
