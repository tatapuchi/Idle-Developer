using Idle.Core.Models;
using Idle.Helpers;
using System;
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

            //Upon starting, load and initialzie our static player object from data in the file
            player = FileHelper.ReadPlayer();

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
