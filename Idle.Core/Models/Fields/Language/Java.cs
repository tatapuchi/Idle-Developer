using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    //Example implementation of Languages abstract class
    public sealed class Java : Languages
    {
        private string name = "Java";
        public override string Name { get => name; set => name = value; }

        private string description = "A coffee language";
        public override string Description { get => description; set => description = value; }

        private int xp = 0;
        public override int XP { get => xp; set => xp = value; }

        private int level = 1;
        public override int Level { get => level; set => level = value; }
    }
}
