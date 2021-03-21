using Idle.Core.ViewModels;
using Idle.Helpers;
using Sharpnado.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Sections
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FieldSection : ContentView, IAnimatableReveal
    {
        SessionPageVM VM = new SessionPageVM();
        public FieldSection()
        {
            InitializeComponent();
            VM.Languages = App.player.GetLanguageCollection();
            BindingContext = VM;
            CollectionList.ItemsSource = VM.Languages;
        }

        public bool Animate { get; set; }

        private void Save_Clicked(object sender, EventArgs e)
        {
            App.player.UpdateLanguages(VM.Languages);
            FileHelper.WritePlayer(App.player);
        }
    }
}