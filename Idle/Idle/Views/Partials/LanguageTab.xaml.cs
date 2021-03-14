using Idle.Core.ViewModels;
using Idle.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Partials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageTab : ContentPage
    {
        SessionPageVM VM = new SessionPageVM();
        public LanguageTab()
        {
            InitializeComponent();

            VM.Languages = App.player.GetLanguageCollection();
            BindingContext = VM;
            LanguageList.ItemsSource = VM.Languages;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            App.player.UpdateLanguages(VM.Languages);
            FileHelper.WritePlayer(App.player);
        }
    }
}