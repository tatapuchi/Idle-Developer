using Idle.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Idle.Logic.Shop
{
    //This is the viewmodel for the flyoutpage itself, this serves no other purpose but to be able to navigate to it
    public class ShopViewModel: ViewModelBase
    {

        private readonly INavigationService _navigation;

        public ShopViewModel(INavigationService navigation)
        {
            _navigation = navigation;
        }

    }
}
