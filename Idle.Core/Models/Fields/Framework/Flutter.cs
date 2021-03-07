using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Framework
{
    public sealed class Flutter : Frameworks
    {
        public Flutter()
        {
            Name = "Flutter";
            Description = "A App Development for Dart";
            Framework = Field.Framework.Flutter;
        }
    }
}
