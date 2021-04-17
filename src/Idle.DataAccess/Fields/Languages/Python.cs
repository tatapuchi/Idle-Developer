﻿using Idle.DataAccess.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields.Languages
{
    [Table(TableNames.Languages)]
    public class Python : Language
    {
        public Python()
        {
        }
        public override string ImagePath => "Idle.Framework.Images.Languages.Csharp.png";
        public override string Name => "Python";

        public override string Description => "snek";

        public override Difficulty Difficulty => Difficulty.Medium;
        public override int XPCost => 550;
        public override int XPIncome => 45;
    }
}
