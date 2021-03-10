using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Items
{
    public class Item
    {

        public Item()
        {
            Name = "Item";
            Description = "Some Item";
            Amount = 1;
            Cost = 100;
            Type = ItemType.None;
            rarity = Rarity.Common;
        }

        public string Name { get; set; }
        public int Amount { get; set; }
        public int Cost { get; set; }

        private int _maxStackAmount = 1;
        public int MaxStackAmount { get => _maxStackAmount; set => _maxStackAmount = value; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public Rarity rarity { get; set; }


        public enum Rarity
        {
            Common,
            Uncommon,
            Rare,
            Epic,
            Legendary,
            Mythical,
            Ancient,
            Forbidden
        }

        public enum ItemType
        {
            None,
            GitHubOne,
            GitHubEnterprise,
            GitHubPro,
            GitHubTeam,
            Rider,
            CLion,
            Bamboo,
            AdobeXD,
            AdobeAe,
            AdobeAi
        }



    }
}
