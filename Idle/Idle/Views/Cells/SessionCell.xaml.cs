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

        private Field _field;

        public SessionCell()
        {
            InitializeComponent();

            Task.Run(async () =>
            {

                
                while (true)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (ProgressBar.Progress >= 1.0f)
                        {
                            //_field.Level++;
                            _field.XP += 35;

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
            _field = BindingContext as Field;
        }

        private void Upgrade_Clicked(object sender, EventArgs e)
        {
            if (ProgressBar.Progress <= 0.9f) { ProgressBar.Progress += 0.1f; }
            else { ProgressBar.Progress = 1.0f; }
        }
    }
}