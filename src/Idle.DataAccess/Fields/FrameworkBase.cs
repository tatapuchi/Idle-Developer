using Idle.DataAccess.Buffs;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Idle.DataAccess.Fields
{
    /// <summary>
    /// Abstract class for all frameworks
    /// </summary>
    public abstract class FrameworkBase : ModelBase, IDescriptive, IBuffing, IProgress, ICost, IRequirement
    {
        // Descriptive Properties
        /// <summary>
        /// Name of the framework
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// Description of the framework
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Difficulty of the framework
        /// </summary>
        public abstract ModelBase.Difficulty Difficulty { get; }



        // Buff Properties
        private float _xpMult = 1f;
        /// <summary>
        /// Base XP Multiplier of this framework, the starter value may vary depending on the framework
        /// </summary>
        public float XPMult { get => _xpMult; set => _xpMult = value; }

        private float _speedMult = 1f;
        /// <summary>
        /// Base Speed Multiplier of this framework, the starter value may vary depending on the framework
        /// </summary>
        public float SpeedMult { get => _speedMult; set => _speedMult = value; }
        /// <summary>
        /// What buffs the framework can be affected by
        /// </summary>
        public abstract List<BuffBase> Buffs { get; }



        // Progression Properties
        private int _xp = 0;
        /// <summary>
        /// XP in this framework
        /// </summary>
        public int XP { get => _xp; set => _xp = value; }

        private int _level = 1;
        /// <summary>
        /// Level in this framework
        /// </summary>
        public int Level { get => _level; set => _level = value; }

        private string _grade = "F";
        /// <summary>
        /// Grade in this framework
        /// </summary>
        public string Grade { get => _grade; set => _grade = value; }



        // Miscellaneous Properties
        /// <summary>
        /// Cost of this framework
        /// </summary>
        public abstract int Cost { get; }



        //Requirement Properties
        /// <summary>
        /// Required langauges for this framework
        /// </summary>
        public abstract HashSet<LanguageBase> Languages { get; }
        /// <summary>
        /// Required frameworks for this framework
        /// </summary>
        public abstract HashSet<FrameworkBase> Frameworks { get; }
        /// <summary>
        /// Required tools for this framework
        /// </summary>
        public abstract HashSet<ToolBase> Tools { get; }
        /// <summary>
        /// Required minimum player level for this framework
        /// </summary>
        public abstract int PlayerLevel { get; }

    }
}
