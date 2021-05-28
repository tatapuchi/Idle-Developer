using Idle.Models.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Models.Fields.Languages
{
    [Table(TableNames.Languages)]
    public class CSharp : Language
    {
        //public override string ImagePath => "Idle.Resources.Images.Languages.Csharp.png";

        public override string Name => "C#";

        public override string Description => "It lets you see sharp. Ba dum tss.";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 850;
        public override int XPIncome => 20;

    }
}
