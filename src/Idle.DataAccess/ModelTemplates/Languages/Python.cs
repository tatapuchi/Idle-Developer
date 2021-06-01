using Idle.Models.Common;
using Idle.Models.Models;
using SQLite;

namespace Idle.DataAccess.ModelTemplates.Languages
{
	[Table(TableNames.Languages)]
    public class Python : Language
    {
        public Python()
        {
        }
        public override string ImagePath => "Idle.Resources.Images.Languages.Python.png";
        public override string Name => "Language.Python.Name";

        public override string Description => "Language.Python.Description";

        public override Difficulty Difficulty => Difficulty.Medium;
        public override int XPCost => 550;
        public override int XPIncome => 45;
    }
}
