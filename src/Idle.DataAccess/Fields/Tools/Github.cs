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
    public class Github : ITool, IXPCost
    {
        public Github()
        {
        }

        public int ID { get; set; }

        public string Name => "GitHub";

        public string Description => "The ultimate platform";

        public Difficulty Difficulty => Difficulty.Easy;

        public int XPCost => 500;
        public int XPIncome => 30;

        public int XP { get; set; }
        public int Level { get; set; }
        public string Grade { get; set; }
    }
}
