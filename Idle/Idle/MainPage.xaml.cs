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
            
            FileEntry.Text = App.player.LanguageList.ToString();
        }

        private void Java_Clicked(object sender, EventArgs e)
        {
            App.player.LanguageList |= Core.Models.Field.Language.Java;
            FileEntry.Text = App.player.LanguageList.ToString();
            FileHelper.WritePlayer(App.player);
        }

        private void HTML_Clicked(object sender, EventArgs e)
        {
            App.player.LanguageList |= Core.Models.Field.Language.HTML;
            FileEntry.Text = App.player.LanguageList.ToString();
            FileHelper.WritePlayer(App.player);
        }

        private void CSS_Clicked(object sender, EventArgs e)
        {
            App.player.LanguageList |= Core.Models.Field.Language.CSS;
            FileEntry.Text = App.player.LanguageList.ToString();
            FileHelper.WritePlayer(App.player);
        }

        private void JavaScript_Clicked(object sender, EventArgs e)
        {
            App.player.LanguageList |= Core.Models.Field.Language.JavaScript;
            FileEntry.Text = App.player.LanguageList.ToString();
            FileHelper.WritePlayer(App.player);
        }

        private void Python_Clicked(object sender, EventArgs e)
        {
            App.player.LanguageList |= Core.Models.Field.Language.Python;
            FileEntry.Text = App.player.LanguageList.ToString();
            FileHelper.WritePlayer(App.player);
        }

        private void BtnSessionProgress_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SessionProgress();
        }
    }
}
