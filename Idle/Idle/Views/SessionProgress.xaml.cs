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
        }

        private void Upgrade_Clicked(object sender, EventArgs e)
        {
            progress += 0.1f;
            ProgressBar.Progress = progress;
        }

        private void Upgrade1_Clicked(object sender, EventArgs e)
        {
            progress1 += 0.1f;
            ProgressBar1.Progress = progress1;
        }

        private void Upgrade2_Clicked(object sender, EventArgs e)
        {
            progress2 += 0.1f;
            ProgressBar2.Progress = progress2;
        }
    }
}