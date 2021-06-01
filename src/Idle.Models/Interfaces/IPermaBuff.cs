using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Models.Interfaces
{
    public interface IPermaBuff
    {
        public string Name { get; }
        public float PlayerXPMultiplierAddon { get; set; }
        public float XPMultiplierAddon { get; set; }
        public float SpeedMultiplierAddon { get; set; }
    }
}
