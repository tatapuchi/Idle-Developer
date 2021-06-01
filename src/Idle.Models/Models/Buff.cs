using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Models.Models
{
    public class Buff
    {
        //Buff doesnt implement IDescriptive, because there is no Difficulty to a buff
        public virtual string Name { get; set; }
        public virtual float PlayerXPMultiplierAddon { get; set; }
        public virtual float XPMultiplierAddon { get; set; }
        public virtual float SpeedMultiplierAddon { get; set; }

        public virtual HashSet<Type> AffectedLanguages { get; set; }

        public virtual int Strength { get; set; }
    }
}
