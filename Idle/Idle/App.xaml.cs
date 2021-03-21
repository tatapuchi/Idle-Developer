using Idle.Core.Models;
using Idle.Core.Models.Player;
using Idle.Helpers;
using Idle.Views;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle
{
    public partial class App : Application
    {
        //Single Player object used by code to update the player
        public static Player player = new Player();
        public static Info info = new Info();

        //Number of times opened
        public static int timesopened;
        public App()
        {
            InitializeComponent();



            //Initialize Sharpnado tabs
            Sharpnado.Tabs.Initializer.Initialize(false, false);
            //Initialize Sharpnado shadows
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);


            //Check how many times the app has been opened
            #region Times Opened

            if (Preferences.ContainsKey("Times_Opened"))
            { 
                Preferences.Set("Times_Opened", Preferences.Get("Times_Opened", 1) + 1);
                player.Update(FileHelper.ReadPlayer());
                MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                Preferences.Set("Times_Opened", 1);
                FileHelper.WritePlayer(player.Convert());
                MainPage = new NavigationPage(new SetupPage());
            }

            timesopened = Preferences.Get("Times_Opened", 1);

            #endregion




            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            //Upon finishing, save the player data back to our file
            FileHelper.WritePlayer(player.Convert());
        }

        protected override void OnResume()
        {
        }
    }
}
