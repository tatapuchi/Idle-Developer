using Idle.Core.Models;
using Idle.Core.Models.Items;
using Idle.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idle.Views.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IDETab : ContentPage
    {
        //this is constantly updating the itemsource so chagne it
        ObservableCollection<Item> Items = new ObservableCollection<Item>();
        public IDETab()
        {
            InitializeComponent();
            Items = SessionHelper.GetInventory(App.player.Inventory);
            InventoryList.ItemsSource = Items;
            var x = Items[2].Amount;
        }

        private void GithubEnterprise_Clicked(object sender, EventArgs e)
        {
            App.player.AddItem(nameof(Core.Models.Items.GithubEnterprise));
        }

        private void GithubOne_Clicked(object sender, EventArgs e)
        {
            App.player.AddItem(nameof(Core.Models.Items.GithubOne));
        }

        private void GithubTeams_Clicked(object sender, EventArgs e)
        {
            App.player.AddItem(nameof(Core.Models.Items.GithubTeam));
        }

        private void GithubPro_Clicked(object sender, EventArgs e)
        {
            App.player.AddItem(nameof(Core.Models.Items.GithubPro));
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            //Work on a observablecollection to sortedlist method for inventory
            FileHelper.WritePlayer(App.player.ConvertToDTO());
        }
    }
}