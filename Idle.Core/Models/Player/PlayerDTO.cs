using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Field;

namespace Idle.Core.Models.Player
{
    public class PlayerDTO
    {
        public int XP { get; set; }
        public int Level { get; set; }
        public int Coins { get; set; }
        public Language LanguageList { get; set; }

        public Framework FrameworkList { get; set; }
        public Tool ToolList { get; set; }
        public SortedList<string, FieldDTO> Fields {get; set;}

    }
}
