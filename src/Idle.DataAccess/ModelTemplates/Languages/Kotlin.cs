﻿using Idle.Models.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.ModelTemplates.Languages
{
    [Table(TableNames.Languages)]
    public class Kotlin : Language
    {
        public Kotlin()
        {
        }
     
        public override string Name => "Kotlin";

        public override string Description => "A language for building android apps.";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 450;
        public override int XPIncome => 25;
    }
}
