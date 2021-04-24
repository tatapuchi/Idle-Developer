
using Idle.DataAccess;
using Idle.DataAccess.Migrators;
using Idle.ResourceAccess;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            var languageMigrator = new LanguageMigrator();
            languageMigrator.Migrate();

            var fileSystemMigrator = new FileSystemMigrator();
            fileSystemMigrator.Migrate();

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
