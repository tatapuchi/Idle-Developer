using Idle.DataAccess.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields.Languages
{
    [Table(TableNames.Languages)]
    public class Java : Language
    {
        public Java()
        {
        }

        public override string Name => "Java";

        public override string Description => "le coffee";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 750;
        public override int XPIncome => 20;
    }
}
