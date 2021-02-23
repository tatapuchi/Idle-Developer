using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models
{
    //Top level Item type
    public interface Item
    {

        //Name of item eg: HP Omen 15, RTX 3090
        public string Name { get; set; }

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

    }
}
