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
    public class ExampleProject : IProject
    {
        public ExampleProject()
        {

        }

        public int ID { get; set; }

        public string Name  => "Malware";

        public string Description => "Why would you make this?";

        public Difficulty Difficulty => Difficulty.Medium;

        public HashSet<LanguageBase> Languages => new HashSet<LanguageBase>() { new CSharp() };

        public HashSet<FrameworkBase> Frameworks => new HashSet<FrameworkBase>() { new Flutter() };

        public HashSet<ToolBase> Tools => new HashSet<ToolBase>() { new Github() };

        public int PlayerLevel => 50;

        public int XP { get; set; }
        public int Level { get; set; }
        public string Grade { get; set; }

        public int XPIncome => 40;

        public int CoinIncome => 20;

    }
}
