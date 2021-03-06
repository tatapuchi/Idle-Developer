using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models
{
    //Top level Item type
    public abstract class Item
    {

        //Name of item eg: HP Omen 15, RTX 3090
        public virtual string Name { get; set; }
        public virtual int Amount { get; set; }
        public virtual int Cost { get; set; }

        private int _maxStackAmount = 1;
        public virtual int MaxStackAmount { get => _maxStackAmount; set => _maxStackAmount = value; }
        //Description of item
        public virtual string Description { get; set; }

        //Rarity of a given item
        public virtual Rarity rarity { get; set; }

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
