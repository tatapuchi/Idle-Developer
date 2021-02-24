using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class Kotlin : Languages
    {
        private string name = "Kotlin";
        public override string Name { get => name; set => name = value; }

        private string description = "An android language";
        public override string Description { get => description; set => description = value; }



        //Default amount of xp
        private int xp = 0;
        public override int XP { get => xp; set => xp = value; }


        //Default level
        private int level = 1;
        public override int Level { get => level; set => level = value; }



    }
}
