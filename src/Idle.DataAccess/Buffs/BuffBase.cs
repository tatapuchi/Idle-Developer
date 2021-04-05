using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Buffs
{
    /// <summary>
    /// Base class for all buffs. To be implemented.
    /// </summary>
    public abstract class BuffBase
    {
        /// <summary>
        /// Float value that this buffs adds to XP multipliers
        /// </summary>
        public float XPMult { get; set; }

        /// <summary>
        /// Float value that this buff adds to speed multipliers
        /// </summary>
        public float SpeedMult { get; set; }
    }
}
