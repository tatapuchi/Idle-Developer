using Idle.Core.Models;
using Idle.Core.Models.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionCell : ViewCell
    {
        //Perhaps set the Task.Delay() value to be bound to the level of the itemsource object with some multiplier
        private int _level;
        private int _xp;
        private Languages _language;

        public SessionCell()
        {
            InitializeComponent();
            //_level = Int32.Parse(LevelLabel.Text);
            //_xp = Int32.Parse(XPLabel.Text);

            Task.Run(async () =>
            {

                
                while (true)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (ProgressBar.Progress >= 1.0f)
                        {
                            //_level++;
                            //_xp++;
                            //var level = Int32.Parse(LevelLabel.Text);
                            //var xp = Int32.Parse(XPLabel.Text);
                            //LevelLabel.Text = level.ToString();
                            //XPLabel.Text = xp.ToString();
                            _language.Level++;
                            _language.XP += 35;
                            //BindingContext = _language;

                            ProgressBar.Progress = 0.0f;
                        }

                        ProgressBar.Progress += 0.01f;

                    });

                    await Task.Delay(40);

                }

            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _language = BindingContext as Languages;

        }

        private void Upgrade_Clicked(object sender, EventArgs e)
        {
            if (ProgressBar.Progress <= 0.9f) { ProgressBar.Progress += 0.1f; }
            else { ProgressBar.Progress = 1.0f; }
        }
    }
}