using Idle.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields
{
    /// <summary>
    /// Abstract base class for all languages
    /// </summary>
    public abstract class LanguageBase : ModelBase, IDescriptive, IProgress, IXPCost
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
        public abstract Difficulty Difficulty { get; }



        // Progression Properties
        /// <summary>
        /// XP in this language
        /// </summary>
        public int XP { get; set; } = 0;
        /// <summary>
        /// Level in this language
        /// </summary>
        public int Level { get; set; } = 1;
        /// <summary>
        /// Grade in this language
        /// </summary>
        public string Grade { get; set; } = "F";



        // Miscellaneous Properties
        /// <summary>
        /// Cost of this language
        /// </summary>
        public abstract int XPCost { get; }

    }
}
