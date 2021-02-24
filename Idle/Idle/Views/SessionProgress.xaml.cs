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
    public partial class SessionProgress : ContentPage
    {
        private float progress = 0;
        private float progress1 = 0;
        private float progress2 = 0;

        public SessionProgress()
        {
            InitializeComponent();
            JavaLabel.Text = App.player.Fields[0].Level.ToString();

            Task.Run(async () =>
            {

                while (true)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if(JavaProgressBar.Progress >= 1.0f)
                        {
                            App.player.Fields[0].Level++;
                            App.player.Fields[0].XP += 35;
                            JavaProgressBar.Progress = 0.0f;
                            JavaLabel.Text = $"Level {App.player.Fields[0].Level}, {App.player.Fields[0].XP} XP";
                        }
                        JavaProgressBar.Progress += 0.01f;

                    });

                    await Task.Delay(40);

                }
            });
        }


        private void Upgrade1_Clicked(object sender, EventArgs e)
        {
            if (JavaProgressBar.Progress <= 0.9f) {
                JavaProgressBar.Progress += 0.1f;
            }
            else { JavaProgressBar.Progress = 1.0f; }
        }


        private void Upgrade_Clicked(object sender, EventArgs e)
        {
            progress += 0.1f;
            ProgressBar.Progress = progress;
        }

        private void Upgrade2_Clicked(object sender, EventArgs e)
        {
            progress2 += 0.1f;
            ProgressBar2.Progress = progress2;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            FileHelper.WritePlayer(App.player);
        }
    }
}