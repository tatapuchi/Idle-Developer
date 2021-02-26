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


        public override string Name { get; set; }

        public override string Description { get; set; }



        public override int XP { get; set; }

        public override int Level { get; set; }
    }


}

