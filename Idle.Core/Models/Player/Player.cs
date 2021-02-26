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
            Fields = new SortedList<string, FieldDTO>();
            Inventory = new SortedList<string, int>();

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
        public SortedList<string, FieldDTO> Fields { get; set; }

        public SortedList<string, int> Inventory { get; set; }
        #endregion


        //Methods regarding adding and removing items from the inventory
        #region Inventory Methods
        public void AddInventory(string key)
        {
            if (Inventory.ContainsKey(key))
            {
                Inventory[key]++;
                return;
            }

            Inventory.Add(key, 1);

        }

        public void RemoveInventory(string key)
        {
            if (Inventory.ContainsKey(key))
            {
                if (Inventory[key] > 1)
                {
                    Inventory[key]--;
                }

                Inventory.Remove(key);

            }

        }

        #endregion


        //Methods regarding adding flags to enums and to the Fields SortedList
        #region Field Methods
        public void AddLanguage(Field.Language language)
        {
            if (LanguageList.HasFlag(language)) { return; }
            LanguageList |= language;
            Fields.Add(language.ToString(), Languages.GetLanguage(language).ConvertToDTO());
        }

        public void AddFramework(Field.Framework framework)
        {
            if (FrameworkList.HasFlag(framework)) { return; }
            FrameworkList |= framework;
            Fields.Add(framework.ToString(), Frameworks.GetFramework(framework).ConvertToDTO());
        }

        public void AddTool(Field.Tool tool)
        {
            if (ToolList.HasFlag(tool)) { return; }
            ToolList |= tool;
            Fields.Add(tool.ToString(), Tools.GetTool(tool).ConvertToDTO());
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
                Fields = Fields,
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
            Fields = dto.Fields;
            Inventory = dto.Inventory;
        }


        #endregion

    }
}
