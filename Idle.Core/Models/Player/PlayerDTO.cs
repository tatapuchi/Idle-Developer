using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Field;

namespace Idle.Core.Models.Player
{
    //Data Transfer class for player
    public class PlayerDTO
    {
        //Current XP of the player
        public int XP { get; set; }

        //Current Level of the player
        public int Level { get; set; }

        //Number of coins player currently has
        public int Coins { get; set; }

        //Enum Flags meant to hold the fields(of subtype language) that the player currently has access to
        public Language LanguageList { get; set; }

        //Enum Flags meant to hold the fields (of subtype framework) that the player currently has access to
        public Framework FrameworkList { get; set; }

        //Enum Flags meant to hold the fields (of subtype tool) that the player currently has access to
        public Tool ToolList { get; set; }

        //SortedList of Fields meant to keep track of the players progress (XP and level) for a certain field, eg: Java (360 XP at Level 3) or Kotlin (7400 XP at Level 15)
        public SortedList<Field.Language, FieldDTO> Languages { get; set; }
        public SortedList<Field.Framework, FieldDTO> Frameworks { get; set; }
        public SortedList<Field.Tool, FieldDTO> Tools { get; set; }

        //Inventory, meant to store the name of the item eg: nameof(PyCharm) as a string, and the amount of said item 
        public SortedList<Item.ItemType, int> Inventory { get; set; }

    }
}
