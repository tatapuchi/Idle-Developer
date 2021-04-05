using Idle.DataAccess.Buffs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields
{
    /// <summary>
    /// Abstract class for all tools
    /// </summary>
    public abstract class ToolBase : ModelBase, IDescriptive, IBuffing, IProgress, ICost
    {
        // Descriptive Properties
        /// <summary>
        /// Name of the tool
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// Description of the tool
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Difficulty of the tool
        /// </summary>
        public abstract ModelBase.Difficulty Difficulty { get; }



        // Buff Properties
        private float _xpMult = 1f;
        /// <summary>
        /// Base XP Multiplier of this tool, the starter value may vary depending on the tool
        /// </summary>
        public float XPMult { get => _xpMult; set => _xpMult = value; }

        private float _speedMult = 1f;
        /// <summary>
        /// Base Speed Multiplier of this tool, the starter value may vary depending on the tool
        /// </summary>
        public float SpeedMult { get => _speedMult; set => _speedMult = value; }
        /// <summary>
        /// What buffs the tool can be affected by
        /// </summary>
        public abstract List<BuffBase> Buffs { get;}



        // Progression Properties
        private int _xp = 0;
        /// <summary>
        /// XP in this language
        /// </summary>
        public int XP { get => _xp; set => _xp = value; }

        private int _level = 1;
        /// <summary>
        /// Level in this lanugage
        /// </summary>
        public int Level { get => _level; set => _level = value; }

        private string _grade = "F";
        /// <summary>
        /// Grade in this language
        /// </summary>
        public string Grade { get => _grade; set => _grade = value; }



        // Miscellaneous Properties
        /// <summary>
        /// Cost of this tool, could be in player XP, but also in coins if this is a proprietary tool
        /// </summary>
        public abstract int Cost { get; }


        // Tool Specific Properties
        /// <summary>
        /// Whether this tool is bought for Player XP (false), or for Coins (true)
        /// </summary>
        public abstract bool Proprietary { get; }

    }
}
