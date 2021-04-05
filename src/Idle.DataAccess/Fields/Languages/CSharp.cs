using Idle.DataAccess.Buffs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Fields.Languages
{
    /// <summary>
    /// Class for the C# language
    /// </summary>
    public class CSharp : LanguageBase
    {
        public CSharp()
        {
            SpeedMult = 0.8f;
            XPMult = 0.9f;
        }

        public override string Name => "C#";

        public override string Description => "Alternatively known as D flat, used to make games such as terraria and many more. A general purpose language, used basically everywhere, its C#.";

        public override Difficulty Difficulty => Difficulty.Hard;
        public override List<BuffBase> Buffs => new List<BuffBase>() { };

        public override int Cost => 850;
    }
}
