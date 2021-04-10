using Idle.DataAccess.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields.Languages
{
    [Table(TableNames.Languages)]
    public class Kotlin : LanguageBase
    {
        public Kotlin()
        {
        }

        public override string Name => "Kotlin";

        public override string Description => "ander roid";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 450;
        public override int XPIncome => 25;
    }
}
