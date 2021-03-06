using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class CSS : Languages
    {


        public CSS()
        {
            Name = "CSS";
            Description = "Style sheets";
            Language = Field.Language.CSS;
        }


        public override string ToString()
        {
            return nameof(CSS);
        }

    }
}
