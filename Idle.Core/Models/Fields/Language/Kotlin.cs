using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class Kotlin : Languages
    {


        public Kotlin()
        {
            Name = "Kotlin";
            Description = "An Android Language";
            Language = Field.Language.Kotlin;
        }



        public override string ToString()
        {
            return nameof(Kotlin);
        }

    }




}

