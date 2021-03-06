using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    //Example implementation of Languages abstract class
    public sealed class Java : Languages
    {
        public Java()
        {
            Name = "Java";
            Description = "A Coffee Language";
        }



        public override string ToString()
        {
            return nameof(Java);
        }
    }


}

