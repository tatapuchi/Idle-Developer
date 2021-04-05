using Idle.DataAccess.Buffs;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Idle.DataAccess.Fields.Tools
{
    /// <summary>
    /// Clas for the github tool
    /// </summary>
    public class Github : ToolBase
    {
        public Github()
        {
            XPMult = 1.5f;
            SpeedMult = 1.8f;
        }

        public override string Name => "GitHub";

        public override string Description => "The ultimate platform";

        public override Difficulty Difficulty => Difficulty.Easy;

        public override List<BuffBase> Buffs => new List<BuffBase>() { };

        public override int Cost => 500;

        public override bool Proprietary => false;
    }
}
