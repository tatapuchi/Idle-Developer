using Idle.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields
{
    /// <summary>
    /// Abstract base class for all languages
    /// </summary>
    public class LanguageBase : ModelBase, IDescriptive, IProgress, IXPCost, IXPIncome
    {
        // Descriptive Properties
        /// <summary>
        /// Name of the language
        /// </summary>
        public virtual string Name => throw new NotImplementedException();
        /// <summary>
        /// Description of the language
        /// </summary>
        public virtual string Description => throw new NotImplementedException();
        /// <summary>
        /// Difficulty of the language
        /// </summary>
        public virtual Difficulty Difficulty => throw new NotImplementedException();



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
        public virtual int XPCost => throw new NotImplementedException();

        public virtual int XPIncome => throw new NotImplementedException();

    }
}
