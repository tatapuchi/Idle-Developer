using Idle.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Idle.DataAccess.Fields.Tools
{
    /// <summary>
    /// Clas for the github tool
    /// </summary>
    public class Github : ToolBase, IXPCost
    {
        public Github()
        {
        }

        public override string Name => "GitHub";

        public override string Description => "The ultimate platform";

        public override Difficulty Difficulty => Difficulty.Easy;

        public int XPCost => 500;

        public override bool Proprietary => false;
    }
}
