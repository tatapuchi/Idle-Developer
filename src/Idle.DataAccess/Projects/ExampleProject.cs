using Idle.DataAccess.Enums;
using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Frameworks;
using Idle.DataAccess.Fields.Languages;
using Idle.DataAccess.Fields.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Projects
{
    public class ExampleProject : ProjectBase
    {
        public ExampleProject()
        {
            Income = 700;
        }

        public override string Name => "Malware";

        public override string Description => "Why would you make this?";

        public override Difficulty Difficulty => Difficulty.Medium;

        public override HashSet<LanguageBase> Languages => new HashSet<LanguageBase>() { new CSharp() };

        public override HashSet<FrameworkBase> Frameworks => new HashSet<FrameworkBase>() { new Flutter() };

        public override HashSet<ToolBase> Tools => new HashSet<ToolBase>() { new Github() };

        public override int PlayerLevel => 50;
    }
}
