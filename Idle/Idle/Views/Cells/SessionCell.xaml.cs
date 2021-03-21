using Idle.Core.Models;
using Idle.Core.Models.Fields;
using Sharpnado.Tabs;
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
    public partial class SessionCell : ViewCell, IAnimatableReveal
    {

        private IField _field;

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

        public bool Animate { get; set;}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _field = BindingContext as IField;
        }

        private void Progress(object sender, EventArgs e)
        {
            if (ProgressBar.Progress <= 0.9f) { ProgressBar.Progress += 0.1f; }
            else { ProgressBar.Progress = 1.0f; }
        }

        private void Upgrade_Clicked(object sender, EventArgs e)
        {
            if(_field.XP >= 50) { App.Current.MainPage.Navigation.PushAsync(new UpgradePage(_field)); }
        }
    }
}