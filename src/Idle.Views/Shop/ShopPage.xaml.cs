using Idle.Logic.Interfaces;
using Idle.Views.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : FlyoutPage
    {
        public ShopPage()
        {

            InitializeComponent();

            flyoutPage.listView.ItemSelected += OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;
            }

        }


        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            INavigationService s;

            var item = e.SelectedItem as FlyoutPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                //Detail = _navigation.PushAsync<(item.TargetType)>(true);
                flyoutPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}