using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class SQL: Languages
    {
        public SQL()
        {
            Name = "SQL";
            Description = "A Data Language";
            Language = Field.Language.SQL;
        }
    }
}
