using Idle.Models.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Models.Fields.Languages
{
    [Table(TableNames.Languages)]
    public class Java : Language
    {
        public Java()
        {
        }

        public override string Name => "Java";

        public override string Description => "A language like C# but not C#";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 750;
        public override int XPIncome => 20;
    }
}
