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
