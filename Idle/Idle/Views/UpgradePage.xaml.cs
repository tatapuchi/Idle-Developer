using Idle.Core.Models.Fields;
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
    public partial class UpgradePage : ContentPage
    {
        IField field;
        public UpgradePage()
        {
            InitializeComponent();
        }

        public UpgradePage(IField field)
        {
            this.field = field;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(field.XP >= 50)
            {
                field.XP -= 50;
                field.Level++;
            }
        }
    }
}