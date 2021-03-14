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
    public partial class FrameworkTab : ContentPage
    {
        SessionPageVM VM = new SessionPageVM();
        public FrameworkTab()
        {
            InitializeComponent();

            VM.Frameworks = App.player.GetFrameworkCollection();
            BindingContext = VM;
            FrameworkList.ItemsSource = VM.Frameworks;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            App.player.UpdateFrameworks(VM.Frameworks);
            FileHelper.WritePlayer(App.player);
        }
    }
}