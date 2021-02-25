using Idle.Core.Models.Fields;
using Idle.Core.Models.Fields.Language;
using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Field;

namespace Idle.Core.Models.Player
{
    public class PlayerBO
    {

        public PlayerBO()
        {
            _dto.Coins = _coins;
            _dto.XP = _xp;
            _dto.Level = _level;
            _dto.LanguageList = _langaugelist;
            _dto.FrameworkList = _frameworklist;
            _dto.ToolList = _toollist;
            _dto.Fields = _fields;
            _dto.Inventory = _inventory;
        }

        #region Properties

        private PlayerDTO _dto = new PlayerDTO();
        public PlayerDTO DTO { get => _dto; set => _dto = value; }


        private int _xp = 0;
        public int XP { get => _xp; set { _xp = value; _dto.XP = value; } }

        private int _level = 1;
        public int Level { get => _level; set { _level = value; _dto.Level = value; } }

        private int _coins = 0;
        public int Coins { get => _coins; set { _coins = value; _dto.Coins = value; } }


        private Language _langaugelist = Language.None;
        public Language LanguageList { get => _langaugelist; set { _langaugelist = value; _dto.LanguageList = value; 
                _fields.Add(value.ToString(), Languages.GetLanguage(value).DTO);
            }
        }


        private Framework _frameworklist = Framework.None;
        public Framework FrameworkList { get => _frameworklist; set { _frameworklist = value; _dto.FrameworkList = value; } }


        private Tool _toollist = Tool.None;
        public Tool ToolList { get => _toollist; set { _toollist = value; _dto.ToolList = value; } }


        private SortedList<string, FieldDTO> _fields = new SortedList<string, FieldDTO>();
        public SortedList<string, FieldDTO> Fields { get => _fields;}


        public SortedList<string, int> _inventory = new SortedList<string, int>();
        public SortedList<string, int> Inventory { get => _inventory;}

        #endregion Properties

        //Need to get a PlayerBO so we can set stuff from areas in the code, which doesnt work with a DTO

        public void AddInventory(string key)
        {
            if (_inventory.ContainsKey(key))
            {
                _inventory[key]++;
                return;
            }

            _inventory.Add(key, 1);

        }

        public void RemoveInventory(string key)
        {
            if (_inventory.ContainsKey(key))
            {
                if(_inventory[key] > 1)
                {
                    _inventory[key]--;
                }

                _inventory.Remove(key);

            }

        }



        public static PlayerBO DTOtoBO(PlayerDTO dto)
        {

            PlayerBO player = new PlayerBO();
            player._dto = dto;
            player._coins = dto.Coins;
            player._xp = dto.XP;
            player._frameworklist = dto.FrameworkList;
            player._langaugelist = dto.LanguageList;
            player._toollist = dto.ToolList;
            //Copy constructor
            player._fields = new SortedList<string, FieldDTO>(dto.Fields);
            player._inventory = new SortedList<string, int>(dto.Inventory);

            return player;

        }

    }
}
