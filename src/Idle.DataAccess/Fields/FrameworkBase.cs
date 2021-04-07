//using Idle.DataAccess.Enums;
//using System;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Text;

//namespace Idle.DataAccess.Fields
//{
//    /// <summary>
//    /// Abstract class for all frameworks
//    /// </summary>
//    public abstract class FrameworkBase : ModelBase, IDescriptive, IProgress, IXPCost, IRequirement, IXPIncome
//    {
//        // Descriptive Properties
//        /// <summary>
//        /// Name of the framework
//        /// </summary>
//        public abstract string Name { get; }
//        /// <summary>
//        /// Description of the framework
//        /// </summary>
//        public abstract string Description { get; }
//        /// <summary>
//        /// Difficulty of the framework
//        /// </summary>
//        public abstract Difficulty Difficulty { get; }




//        // Progression Properties
//        /// <summary>
//        /// XP in this framework
//        /// </summary>
//        public int XP { get; set; } = 0;
//        /// <summary>
//        /// Level in this framework
//        /// </summary>
//        public int Level { get; set; } = 1;
//        /// <summary>
//        /// Grade in this framework
//        /// </summary>
//        public string Grade { get; set; } = "F";



//        // Miscellaneous Properties
//        /// <summary>
//        /// Cost of this framework
//        /// </summary>
//        public abstract int XPCost { get; }
//        public abstract int XPIncome { get; }



//        //Requirement Properties
//        /// <summary>
//        /// Required langauges for this framework
//        /// </summary>
//        public abstract HashSet<LanguageBase> Languages { get; }
//        /// <summary>
//        /// Required frameworks for this framework
//        /// </summary>
//        public abstract HashSet<FrameworkBase> Frameworks { get; }
//        /// <summary>
//        /// Required tools for this framework
//        /// </summary>
//        public abstract HashSet<ToolBase> Tools { get; }
//        /// <summary>
//        /// Required minimum player level for this framework
//        /// </summary>
//        public abstract int PlayerLevel { get; }

//    }
//}
