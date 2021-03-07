using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Tool
{
    public sealed class Jenkins : Tools
    {
        public Jenkins()
        {
            Name = "Jenkins";
            Description = "A CI/CD Platform.";
            Tool = Field.Tool.Jenkins;
        }
    }
}
