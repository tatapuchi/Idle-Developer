using Idle.DataAccess.Buffs;
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
            XPMult = 0.7f;
            SpeedMult = 0.8f;
        }

        public override string Name => "Flutter";

        public override string Description => "Bird framework that make app.";

        public override Difficulty Difficulty => Difficulty.Medium;

        public override List<BuffBase> Buffs => new List<BuffBase>() { };

        public override int Cost => 1250;

        public override HashSet<LanguageBase> Languages => new HashSet<LanguageBase>() { }; // Add Dart into here

        public override HashSet<FrameworkBase> Frameworks => new HashSet<FrameworkBase>() { };

        public override HashSet<ToolBase> Tools => new HashSet<ToolBase>() { };
    }
}
