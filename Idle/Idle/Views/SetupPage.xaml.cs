using Idle.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetupPage : ContentPage
    {
        public SetupPage()
        {
            InitializeComponent();
        }

        private void HTMLButton_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Fields.IField.LanguageType.HTML);
            FileHelper.WritePlayer(App.player);
            Navigation.PushAsync(new SessionPage());
        }

        private void PythonButton_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Fields.IField.LanguageType.Python);
            FileHelper.WritePlayer(App.player);
            Navigation.PushAsync(new SessionPage());
        }

        private void KotlinButton_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Fields.IField.LanguageType.Kotlin);
            FileHelper.WritePlayer(App.player);
            Navigation.PushAsync(new SessionPage());
        }

        private void SwiftButton_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Fields.IField.LanguageType.Swift);
            FileHelper.WritePlayer(App.player);
            Navigation.PushAsync(new SessionPage());
        }

        private void CPPButton_Clicked(object sender, EventArgs e)
        {
            App.player.AddLanguage(Core.Models.Fields.IField.LanguageType.CPP);
            FileHelper.WritePlayer(App.player);
            Navigation.PushAsync(new SessionPage());
        }
    }
}