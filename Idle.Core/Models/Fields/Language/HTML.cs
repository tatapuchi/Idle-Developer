using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class HTML : Languages
    {


        public HTML()
        {
            Name = "HTML";
            Description = "Just Markup";
        }

        public override string Name { get; set; }

        public override string Description { get; set; }



        public override int XP { get; set; }

        public override int Level { get; set; }


        public override string ToString()
        {
            return nameof(HTML);
        }

    }
}
