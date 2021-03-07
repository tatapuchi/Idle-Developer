using Idle.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Idle.Views;

namespace Idle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Java_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Field.Language.Java);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }



        private void Kotlin_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Field.Language.Kotlin);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }

        private void CSharp_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Field.Language.CSharp);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }

        private void HTML_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Field.Language.HTML);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }

        private void CSS_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Field.Language.CSS);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }

        private void JavaScript_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Field.Language.JavaScript);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }

        private void Python_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Field.Language.Python);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }

        private void BtnSessionProgress_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new SessionProgress();
            Navigation.PushAsync(new SessionPage());
        }

        private void ShopButton_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new ShopPage();
            Navigation.PushAsync(new ShopPage());
        }

        private void UpgradeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpgradePage());
        }

        private void JobButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JobPage());
        }

        private void ProjectButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProjectPage());
        }
    }
}
