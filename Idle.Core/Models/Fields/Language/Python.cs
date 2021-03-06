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


        public override string ToString()
        {
            return nameof(Python);
        }

    }
}
