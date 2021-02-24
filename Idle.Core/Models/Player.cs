using Idle.Core.Models.Fields;
using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Field;

namespace Idle.Core.Models
{
    public class Player
    {

        //Experience Points
        public int XP { get; set; }

        //Level
        public int Level { get; set; }

        //Amount of In-Game Currenncy
        public int Coins { get; set; }

        //Languages the player currently can use
        private Language languagelist;

        public Language LanguageList { get { return languagelist; } set { languagelist = value;
                if (value == Language.Java) { Fields.Add(Languages.GetLanguage(value)); } } }

        //Frameworks the player currently can use
        public Framework Frameworklist { get; set; }

        //Tools the player currently can use
        public Tool Toollist { get; set; }

        public List<Field> Fields { get; set; }



    }
}
