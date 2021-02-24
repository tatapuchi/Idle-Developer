using Idle.Core.Models;
using Idle.Helpers;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle
{
    public partial class App : Application
    {
        //Single Player object used by code to update the player
        public static Player player;
        public App()
        {
            InitializeComponent();

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
