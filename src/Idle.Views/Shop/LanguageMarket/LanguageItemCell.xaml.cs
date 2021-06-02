﻿using Idle.Logic.Shop.LanguageMarket;
using Idle.Views.Common;
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