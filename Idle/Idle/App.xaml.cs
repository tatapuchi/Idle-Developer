using Idle.Core.Models;
using Idle.Helpers;
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
        public static Player player;
        public static int timesopened;
        public App()
        {
            InitializeComponent();

            //Check how many times the app has been opened
            #region Times Opened

            if (Preferences.ContainsKey("Times_Opened")) 
            {
                Preferences.Set("Times_Opened", Preferences.Get("Times_Opened", 1) + 1);
            }
            else
            {
                Preferences.Set("Times_Opened", 1);
            }

            timesopened = Preferences.Get("Times_Opened", 1);

            #endregion




            //Initialize Sharpnado tabs
            Sharpnado.Tabs.Initializer.Initialize(false, false);

            //Upon starting, load and initialzie our static player object from data in the file

            player = new Player();
            player.XP = 0;
            player.Coins = 50;
            player.Level = 1;
            player.LanguageList = Field.Language.None;
            player.Frameworklist = Field.Framework.None;
            player.Toollist = Field.Tool.None;
            player.Fields = new List<Field>();
            player.LanguageList |= Field.Language.Java;
            //FileHelper.WritePlayer(player);

            //player = FileHelper.ReadPlayer();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            //Upon finishing, save the player data back to our file
            FileHelper.WritePlayer(player);
        }

        protected override void OnResume()
        {
        }
    }
}
