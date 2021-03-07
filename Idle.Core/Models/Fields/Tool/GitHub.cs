using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Tool
{
    public sealed class GitHub : Tools
    {
        public GitHub()
        {
            Name = "GitHub";
            Description = "The ultimate coding platform.";
            Tool = Field.Tool.GitHub;
        }
    }
}
