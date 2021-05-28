using Idle.Logic.Shop.Markets;
using Idle.Views.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Shop.Markets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageItemCell : Frame, IViewModel<LanguageItemViewModel>
    {
        public LanguageItemCell()
        {
            InitializeComponent();
        }

        public LanguageItemViewModel ViewModel
        {
            get => (LanguageItemViewModel)BindingContext;
            set => BindingContext = value;
        }
    }
}