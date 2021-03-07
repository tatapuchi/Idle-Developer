using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class Ruby : Languages
    {
        public Ruby()
        {
            Name = "Ruby";
            Description = "A Gem Language";
            Language = Field.Language.Ruby;
        }
    }
}
