using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class Swift : Languages
    {
        public Swift()
        {
            Name = "Swift";
            Description = "An Apple Language";
            Language = Field.Language.Swift;
        }
    }
}
