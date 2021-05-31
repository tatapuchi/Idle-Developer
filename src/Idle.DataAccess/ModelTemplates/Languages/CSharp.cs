using Idle.Models.Common;
using Idle.Models.Models;
using Idle.Resources.L10N;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.ModelTemplates.Languages
{
    [Table(TableNames.Languages)]
    public class CSharp : Language
    {
        //public override string ImagePath => "Idle.Resources.Images.Languages.Csharp.png";

        public override string Name => "Language.CSharp.Name";

        public override string Description => "Language.CSharp.Description";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 850;
        public override int XPIncome => 20;

    }
}
