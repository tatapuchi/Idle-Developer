using Idle.Core.Models.Fields.Language;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields
{

    public abstract class Languages : Field
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int XP { get; set; }
        public virtual int Level { get; set; }

        public static Languages GetLanguage(Field.Language languauge)
        {
            switch (languauge)
            {
                case Field.Language.Java:
                    return new Java();
                case Field.Language.CSharp:
                    return new CSharp();
                case Field.Language.Kotlin:
                    return new Kotlin();

                default:
                    return null;
            }

        }


    }


}
