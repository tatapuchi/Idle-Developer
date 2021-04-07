using Idle.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields.Frameworks
{
    /// <summary>
    /// Class for the flutter framework
    /// </summary>
    public class Flutter : FrameworkBase
    {
        public Flutter()
        {

        }

        public override string Name => "Flutter";

        public override string Description => "Bird framework that make app.";

        public override Difficulty Difficulty => Difficulty.Medium;

        public override int XPCost => 1250;

        public override int XPIncome => 20;

        public override HashSet<LanguageBase> Languages => new HashSet<LanguageBase>() { }; // Add Dart into here

        public override HashSet<FrameworkBase> Frameworks => new HashSet<FrameworkBase>() { };

        public override HashSet<ToolBase> Tools => new HashSet<ToolBase>() { };

        public override int PlayerLevel => 10;

    }
}
