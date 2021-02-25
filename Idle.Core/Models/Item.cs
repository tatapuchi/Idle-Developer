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

        public int MaxStackAmount { get; set; }
        //Description of item
        public string Description { get; set; }

        //Rarity of a given item
        public Rarity rarity { get; set; }

        public static Item GetItem(string item)
        {
            switch (item)
            {
                default:
                    return null;
            }

        }


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

    }
}
