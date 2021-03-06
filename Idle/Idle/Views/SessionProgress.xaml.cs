using Idle.Core.Models;
using Idle.Core.Models.Fields;
using Idle.Core.Models.Fields.Language;
using Idle.Core.ViewModels;
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
        SessionPageVM ViewModel = new SessionPageVM();
        //we need a new way to convert this back to the sortedlist
        //ObservableCollection<Languages> collection = new ObservableCollection<Languages>();

        public SessionProgress()
        {
            InitializeComponent();
            BindingContext = ViewModel;

            ViewModel.Languages = SessionHelper.GetLanguageList(App.player.Languages);
            LanguageList.ItemsSource = ViewModel.Languages;



        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            SessionHelper.UpdateFields(ViewModel.Languages);
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }
    }
}