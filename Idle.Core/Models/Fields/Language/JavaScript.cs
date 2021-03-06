using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class JavaScript : Languages
    {


        public JavaScript()
        {
            Name = "JavaScript";
            Description = "A web Language";
            Language = Field.Language.JavaScript;
        }



        public override string ToString()
        {
            return nameof(JavaScript);
        }

    }
}
