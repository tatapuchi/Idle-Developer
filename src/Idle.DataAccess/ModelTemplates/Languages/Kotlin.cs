using Idle.Models.Common;
using Idle.Models.Models;
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
     
        public override string Name => "Language.Kotlin.Name";

        public override string Description => "Language.Kotlin.Description";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 450;
        public override int XPIncome => 25;
    }
}
