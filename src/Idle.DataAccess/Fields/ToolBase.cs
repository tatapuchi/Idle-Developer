using Idle.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields
{
    /// <summary>
    /// Abstract class for all tools
    /// </summary>
    public abstract class ToolBase : ModelBase, IDescriptive, IProgress
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
        public abstract Difficulty Difficulty { get; }


        // Progression Properties
        /// <summary>
        /// XP in this tool
        /// </summary>
        public int XP { get; set; } = 0;
        /// <summary>
        /// Level in this tool
        /// </summary>
        public int Level { get; set; } = 1;
        /// <summary>
        /// Grade in this tool
        /// </summary>
        public string Grade { get; set; } = "F";


        // Tool Specific Properties
        /// <summary>
        /// Whether this tool is bought for Player XP (false), or for Coins (true)
        /// </summary>
        public abstract bool Proprietary { get; }

    }
}
