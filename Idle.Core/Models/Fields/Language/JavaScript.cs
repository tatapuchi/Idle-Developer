using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class JavaScript : Languages
    {


        public JavaScript()
        {
            Name = "JavaScript";
            Description = "A web Language";
        }

        public override string Name { get; set; }

        public override string Description { get; set; }



        public override int XP { get; set; }

        public override int Level { get; set; }


        public override string ToString()
        {
            return nameof(JavaScript);
        }

    }
}
