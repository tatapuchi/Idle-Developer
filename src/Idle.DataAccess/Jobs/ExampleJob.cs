using Idle.DataAccess.Enums;
using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Frameworks;
using Idle.DataAccess.Fields.Languages;
using Idle.DataAccess.Fields.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Jobs
{
    public class ExampleJob : IJob
    {
        public ExampleJob()
        {
        }

        public int ID { get; set; }
        public string Name => "MacroHard Studios Developer";

        public string Description => "A ripoff of MSFT";

        public Difficulty Difficulty => Difficulty.Medium;

        public HashSet<LanguageBase> Languages => new HashSet<LanguageBase>() { new CSharp() };

        public HashSet<FrameworkBase> Frameworks => new HashSet<FrameworkBase>() { new Flutter() };

        public HashSet<ToolBase> Tools => new HashSet<ToolBase>() { new Github() };

        public int PlayerLevel => 50;

        public int CoinIncome => 40;
        public int XPIncome => 20;

        public int XP { get; set; }
        public int Level { get; set; }
        public string Grade { get; set; }
    }
}
