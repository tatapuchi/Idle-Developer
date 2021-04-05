using Idle.DataAccess.Buffs;
using Idle.DataAccess.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Projects
{
    public abstract class ProjectBase : ModelBase, IDescriptive, IRequirement, IProgress, IBuffing
    {

        private int _income = 100;
        public int Income { get => _income; set => _income = value; }



        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract Difficulty Difficulty { get; }

        public abstract HashSet<LanguageBase> Languages { get; }

        public abstract HashSet<FrameworkBase> Frameworks { get; }

        public abstract HashSet<ToolBase> Tools { get; }
        public abstract int PlayerLevel { get; }

        // Progression Properties
        private int _xp = 0;
        /// <summary>
        /// XP in this project
        /// </summary>
        public int XP { get => _xp; set => _xp = value; }

        private int _level = 1;
        /// <summary>
        /// Level in this project
        /// </summary>
        public int Level { get => _level; set => _level = value; }

        private string _grade = "v1.0.0";
        /// <summary>
        /// Grade in this project
        /// </summary>
        public string Grade { get => _grade; set => _grade = value; }

        // Buff Properties
        private float _xpMult = 1f;
        /// <summary>
        /// Base XP Multiplier of this project, the starter value may vary depending on the project
        /// </summary>
        public float XPMult { get => _xpMult; set => _xpMult = value; }

        private float _speedMult = 1f;
        /// <summary>
        /// Base Speed Multiplier of this project, the starter value may vary depending on the project
        /// </summary>
        public float SpeedMult { get => _speedMult; set => _speedMult = value; }
        /// <summary>
        /// What buffs the project can be affected by
        /// </summary>
        public abstract List<BuffBase> Buffs { get; }

    }
}
