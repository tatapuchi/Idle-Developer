using Idle.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields.Frameworks
{
    /// <summary>
    /// Class for the flutter framework
    /// </summary>
    public class Flutter : IFramework
    {
        public Flutter()
        {

        }

        public int ID { get; set; }
        public string Name => "Flutter";

        public string Description => "Bird framework that make app.";

        public Difficulty Difficulty => Difficulty.Medium;

        public int XPCost => 1250;

        public int XPIncome => 20;

        public HashSet<LanguageBase> Languages => new HashSet<LanguageBase>() { }; // Add Dart into here

        public HashSet<FrameworkBase> Frameworks => new HashSet<FrameworkBase>() { };

        public HashSet<ToolBase> Tools => new HashSet<ToolBase>() { };

        public int PlayerLevel => 10;

        public int XP { get; set; }
        public int Level { get; set; }
        public string Grade { get; set; }

    }
}
