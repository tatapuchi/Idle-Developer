using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models
{
    //Top level Item type
    public abstract class Item
    {

        //Name of item eg: HP Omen 15, RTX 3090
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Cost { get; set; }

        private int _maxStackAmount = 1;
        public int MaxStackAmount { get => _maxStackAmount; set => _maxStackAmount = value; }
        //Description of item
        public string Description { get; set; }

        //Rarity of a given item
        public Rarity rarity { get; set; }


        // Enum type defining rarities
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
        public enum ItemType { GitHubOne, GitHubEnterprise, GitHubPro, GitHubTeam}

    }
}
