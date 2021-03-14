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
    public partial class ToolTab : ContentPage
    {
        SessionPageVM VM = new SessionPageVM();
        public ToolTab()
        {
            InitializeComponent();

            VM.Tools = App.player.GetToolCollection();
            BindingContext = VM;
            ToolList.ItemsSource = VM.Tools;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            App.player.UpdateTools(VM.Tools);
            FileHelper.WritePlayer(App.player);
        }
    }
}