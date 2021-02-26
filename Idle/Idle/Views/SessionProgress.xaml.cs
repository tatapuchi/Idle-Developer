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


            Java java = new Java();
            //java.DTOtoBO(App.player.Fields[nameof(Java)]);
            //JavaLabel.Text = java.Level.ToString();

            //Task.Run(async () =>
            //{

            //    while (true)
            //    {
            //        Device.BeginInvokeOnMainThread(() =>
            //        {
            //            if(JavaProgressBar.Progress >= 1.0f)
            //            {
            //                java.Level++;
            //                java.XP += 35;
            //                JavaProgressBar.Progress = 0.0f;
            //                JavaLabel.Text = $"Level {java.Level}, {java.XP} XP";
            //            }
            //            JavaProgressBar.Progress += 0.01f;

            //        });

            //        await Task.Delay(40);

            //    }
            //});
        }


        private void Upgrade1_Clicked(object sender, EventArgs e)
        {
            if (JavaProgressBar.Progress <= 0.9f) {
                JavaProgressBar.Progress += 0.1f;
            }
            else { JavaProgressBar.Progress = 1.0f; }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }
    }
}