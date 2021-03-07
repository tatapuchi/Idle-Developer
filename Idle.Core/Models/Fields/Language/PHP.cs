using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class PHP: Languages
    {
        public PHP()
        {
            Name = "PHP";
            Description = "A Backend Language";
            Language = Field.Language.PHP;
        }
    }
}
