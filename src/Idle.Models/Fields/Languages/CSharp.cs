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
        public CSharp()
        {
        }
        public override string ImagePath => "Idle.Resources.Images.Languages.Csharp.png";

        public override string Name => "C#";

        public override string Description => "Alternatively known as D flat, used to make games such as terraria and many more. A general purpose language, used basically everywhere, its C#.";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 850;
        public override int XPIncome => 20;
    }
}
