using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Framework
{
    public sealed class BootStrap: Frameworks
    {
        public BootStrap()
        {
            Name = "BootStrap";
            Description = "A CSS library";
            Framework = Field.Framework.BootStrap;
        }
    }
}
