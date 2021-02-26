using Idle.Core.Models;
using Idle.Core.Models.Fields;
using Idle.Core.Models.Fields.Language;
using Idle.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionProgress : ContentPage
    {
        ObservableCollection<Field> collection = new ObservableCollection<Field>();

        public SessionProgress()
        {
            InitializeComponent();
            collection = SessionHelper.GetLanguageList(App.player.Fields);
            LanguageList.ItemsSource = collection;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }
    }
}