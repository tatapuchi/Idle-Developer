using Idle.DataAccess.Enums;
using Idle.DataAccess.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Projects
{

    public abstract class ProjectBase : ModelBase, IDescriptive, IRequirement, IProgress, IXPIncome, ICoinIncome
    {

        // Income Properties
        public abstract int XPIncome { get; }
        public abstract int CoinIncome { get; }



        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract Difficulty Difficulty { get; }

        public abstract HashSet<LanguageBase> Languages { get; }

        public abstract HashSet<FrameworkBase> Frameworks { get; }

        public abstract HashSet<ToolBase> Tools { get; }
        public abstract int PlayerLevel { get; }

        // Progression Properties
        /// <summary>
        /// XP in this project
        /// </summary>
        public int XP { get; set; } = 0;
        /// <summary>
        /// Level in this project
        /// </summary>
        public int Level { get; set; } = 1;
        /// <summary>
        /// Grade in this project
        /// </summary>
        public string Grade { get; set; } = "v1.0.0";


    }
}
