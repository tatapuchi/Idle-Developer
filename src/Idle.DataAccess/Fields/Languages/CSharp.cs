using Idle.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields.Languages
{
    /// <summary>
    /// Class for the C# language
    /// </summary>
    public class CSharp : ILanguage
    {
        public CSharp()
        {
        }

        public int ID { get; set; }
        public string Name => "C#";

        public string Description => "Alternatively known as D flat, used to make games such as terraria and many more. A general purpose language, used basically everywhere, its C#.";

        public Difficulty Difficulty => Difficulty.Hard;
        public int XPCost => 850;
        public int XPIncome => 20;

        public int XP { get; set; }
        public int Level { get; set; }
        public string Grade { get; set; }
    }
}
