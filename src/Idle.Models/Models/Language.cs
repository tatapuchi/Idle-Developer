﻿using Idle.Models.Common;
using Idle.Models.Interfaces;
using SQLite;

namespace Idle.Models.Models
{
	[Table(TableNames.Languages)]
    public class Language : ModelBase, IDescriptive, IProgress, IXPCost, IXPIncome, IActive
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Difficulty Difficulty { get; set; }
        public virtual string ImagePath { get; set; }

        public float Progress { get; set; } = 0.0f;
        public int XP { get; set; } = 0;
        public int Level { get; set; } = 1;

        // todo: use enum
        public string Grade { get; set; } = "F";

        public virtual int XPCost { get; set; }
        public virtual int XPIncome {get; set;}

        public virtual bool IsActive { get; set; }
    }
}
