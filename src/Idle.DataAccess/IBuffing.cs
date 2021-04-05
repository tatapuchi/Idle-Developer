using Idle.DataAccess.Buffs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// Interface to handle buff mechanics, specifically the multipliers and what buffs can affect the subtypes
    /// </summary>
    public interface IBuffing
    {
        /// <summary>
        /// Multiplier for XP earned.
        /// Can be used for Player XP earned every time there is a level up in a language, language/framework/tool XP earnt whenever a session completes, job/project XP earned upon completion, etc.
        /// </summary>
        public float XPMult { get; set; }

        /// <summary>
        /// Multiplier for speed of sessions.
        /// </summary>
        public float SpeedMult { get; set; }

        /// <summary>
        /// List of buffs that can affect this.
        /// </summary>
        public List<BuffBase> Buffs { get; }

    }
}
