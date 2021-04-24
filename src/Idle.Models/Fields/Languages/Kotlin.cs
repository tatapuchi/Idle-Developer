using Idle.Models.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Models.Fields.Languages
{
    [Table(TableNames.Languages)]
    public class Kotlin : Language
    {
        public Kotlin()
        {
        }
        public override string ImagePath => "Idle.Resources.Images.Languages.Kotlin.png";
        public override string Name => "Kotlin";

        public override string Description => "ander roid";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 450;
        public override int XPIncome => 25;
    }
}
