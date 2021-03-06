using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class HTML : Languages
    {


        public HTML()
        {
            Name = "HTML";
            Description = "Just Markup";
        }


        public override string ToString()
        {
            return nameof(HTML);
        }

    }
}
