using Idle.DataAccess.Buffs;
using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Frameworks;
using Idle.DataAccess.Fields.Languages;
using Idle.DataAccess.Fields.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Jobs
{
    public class ExampleJob : JobBase
    {
        public ExampleJob()
        {
            XPMult = 0.5f;
            SpeedMult = 0.8f;
            Income = 500;
        }

        public override string Name => "MacroHard Studios Developer";

        public override string Description => "A ripoff of MSFT";

        public override Difficulty Difficulty => Difficulty.Medium;

        public override HashSet<LanguageBase> Languages => new HashSet<LanguageBase>() { new CSharp() };

        public override HashSet<FrameworkBase> Frameworks => new HashSet<FrameworkBase>() { new Flutter() };

        public override HashSet<ToolBase> Tools => new HashSet<ToolBase>() { new Github() };

        public override int PlayerLevel => 50;

        public override List<BuffBase> Buffs => new List<BuffBase>() { };
    }
}
