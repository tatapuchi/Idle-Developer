using Idle.DataAccess.Fields.Languages;
using Idle.Logic.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Fields
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageView : ContentView
    {
        private LanguageViewModel ViewModel = new LanguageViewModel(new CSharp());
        public LanguageView()
        {
            InitializeComponent();
            BindingContext = ViewModel;
        }
    }
}