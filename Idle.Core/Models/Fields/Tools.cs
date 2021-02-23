using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields
{
    public abstract class Tools : Field
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int XP { get; set; }
        public virtual int Level { get; set; }
    }
}
