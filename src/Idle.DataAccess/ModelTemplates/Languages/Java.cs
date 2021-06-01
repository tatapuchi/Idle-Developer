using Idle.Models.Common;
using Idle.Models.Models;
using SQLite;

namespace Idle.DataAccess.ModelTemplates.Languages
{
	[Table(TableNames.Languages)]
    public class Java : Language
    {
        public Java()
        {
        }

        public override string ImagePath => "Idle.Resources.Images.Languages.Python.png";
        public override string Name => "Language.Java.Name";

        public override string Description => "Language.Java.Description";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override int XPCost => 750;
        public override int XPIncome => 20;
    }
}
