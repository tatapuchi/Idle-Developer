using Idle.Core.Models.Fields;
using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Field;

namespace Idle.Core.Models.Player
{
    /// <summary>
    /// This is the business class for player, it is used to track and record data on the player.
    /// </summary>
    /// <remarks>
    /// DTO class is seperate to this class
    /// </remarks>
    public class Player
    {
        /// <summary>
        /// <c>Player</c> constructor, used to create an object of the player business class and set default values to the properties
        /// </summary>
        public Player()
        {
            //Setting properties to their default values
            XP = 0;
            Level = 1;
            Coins = 0;
            LanguageList = Language.None;
            FrameworkList = Framework.None;
            ToolList = Tool.None;
            Languages = new SortedList<Field.Language, FieldDTO>();
            Frameworks = new SortedList<Field.Framework, FieldDTO>();
            Tools = new SortedList<Field.Tool, FieldDTO>();
            Inventory = new SortedList<Item.ItemType, int>();

        }

        //Player Properties
        #region Properties

        ///<value> Amount of XP the player has </value>
        public int XP { get; set; }

        ///<value> Level the player is at </value>
        public int Level { get; set; }

        ///<value> Amount of coins  the player has </value>
        public int Coins { get; set; }

        ///<value> Enum Flags for which languages the player has access to </value>
        public Language LanguageList { get; set; }

        ///<value> Enum Flags for which frameworks the player has access to </value>
        public Framework FrameworkList { get; set; }

        ///<value> Enum Flags for which tools the player has access to </value>
        public Tool ToolList { get; set; }

        
        public SortedList<Field.Language, FieldDTO> Languages { get; set; }
        public SortedList<Field.Framework, FieldDTO> Frameworks { get; set; }
        public SortedList<Field.Tool, FieldDTO> Tools { get; set; }

        public SortedList<Item.ItemType, int> Inventory { get; set; }
        #endregion


        //Methods regarding adding and removing items from the inventory
        #region Inventory Methods
        public void AddItem(Item.ItemType type)
        {
            FieldInfo info = new FieldInfo();
            //add method that takes in name and gives back maxstackamount
            if (Inventory.ContainsKey(type))
            {
                if (info.GetItem(type).MaxStackAmount <= Inventory[type]) { return; }

                Inventory[type]++;
                return;
            }

            Inventory.Add(type, 1);

        }

        public void RemoveItem(Item.ItemType type)
        {
            if (Inventory.ContainsKey(type))
            {
                if (Inventory[type] > 1)
                {
                    Inventory[type]--;
                }

                Inventory.Remove(type);

            }

        }

        #endregion
        //Methods regarding adding flags to enums and to the Fields SortedList
        #region Field Methods
        public void AddLanguage(Field.Language language)
        {
            FieldInfo info = new FieldInfo();
            if (LanguageList.HasFlag(language)) { return; }
            LanguageList |= language;
            Languages.Add(language, info.GetLanguage(language).ConvertToDTO());
            
        }

        public void AddFramework(Field.Framework framework)
        {
            FieldInfo info = new FieldInfo();
            if (FrameworkList.HasFlag(framework)) { return; }
            FrameworkList |= framework;
            Frameworks.Add(framework, info.GetFramework(framework).ConvertToDTO());
        }

        public void AddTool(Field.Tool tool)
        {
            FieldInfo info = new FieldInfo();
            if (ToolList.HasFlag(tool)) { return; }
            ToolList |= tool;
            Tools.Add(tool, info.GetTool(tool).ConvertToDTO());
        }
        #endregion


        //Methods regarding conversion of the player to a DTO and vice versa
        #region DTO Methods
        public PlayerDTO ConvertToDTO()
        {
            PlayerDTO dto = new PlayerDTO
            {
                XP = XP,
                Level = Level,
                Coins = Coins,
                LanguageList = LanguageList,
                FrameworkList = FrameworkList,
                ToolList = ToolList,
                Languages = Languages,
                Frameworks = Frameworks,
                Tools = Tools,
                Inventory = Inventory
            };


            return dto;

        }

        public void UpdateFromDTO(PlayerDTO dto)
        {
            XP = dto.XP;
            Level = dto.Level;
            Coins = dto.Coins;
            LanguageList = dto.LanguageList;
            FrameworkList = dto.FrameworkList;
            ToolList = dto.ToolList;
            Languages = dto.Languages;
            Frameworks = dto.Frameworks;
            Tools = dto.Tools;
            Inventory = dto.Inventory;
        }


        #endregion

    }
}
