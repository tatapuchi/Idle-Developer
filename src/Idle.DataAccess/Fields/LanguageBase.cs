using Idle.DataAccess.Buffs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields
{
    /// <summary>
    /// Abstract base class for all languages
    /// </summary>
    public abstract class LanguageBase : ModelBase, IDescriptive, IBuffing, IProgress, ICost
    {
        // Descriptive Properties
        /// <summary>
        /// Name of the language
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// Description of the language
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Difficulty of the language
        /// </summary>
        public abstract ModelBase.Difficulty Difficulty { get; }



        // Buff Properties
        private float _xpMult = 1f;
        /// <summary>
        /// Base XP Multiplier of this language, the starter value may vary depending on the language
        /// </summary>
        public float XPMult { get => _xpMult; set => _xpMult = value; }

        private float _speedMult = 1f;
        /// <summary>
        /// Base Speed Multiplier of this language, the starter value may vary depending on the language
        /// </summary>
        public float SpeedMult { get => _speedMult; set => _speedMult = value; }
        /// <summary>
        /// What buffs the langauge can be affected by
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
        /// Level in this language
        /// </summary>
        public int Level { get => _level; set => _level = value; }

        private string _grade = "F";
        /// <summary>
        /// Grade in this language
        /// </summary>
        public string Grade { get => _grade; set => _grade = value; }



        // Miscellaneous Properties
        /// <summary>
        /// Cost of this language
        /// </summary>
        public abstract int Cost { get; }

    }
}
