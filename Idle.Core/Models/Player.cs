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
        public Language Languages { get; set; }

        //Frameworks the player currently can use
        public Framework Frameworks { get; set; }

        //Tools the player currently can use
        public Tool Tools { get; set; }



    }
}
