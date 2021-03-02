using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class Python : Languages
    {


        public Python()
        {
            Name = "Python";
            Description = "A Snake Language";
        }

        public override string Name { get; set; }

        public override string Description { get; set; }



        public override int XP { get; set; }

        public override int Level { get; set; }


        public override string ToString()
        {
            return nameof(Python);
        }

    }
}
