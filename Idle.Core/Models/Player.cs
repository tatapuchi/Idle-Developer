using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models
{
    public class Player
    {
        // XP Cap to advance to the next Level
        public int Cap;

        //Experience Points
        public int XP { get; private set; }

        //Level
        public int Level { get; private set; }

        //Amount of In-Game Currenncy
        public int Coins { get; private set; }


    }
}
