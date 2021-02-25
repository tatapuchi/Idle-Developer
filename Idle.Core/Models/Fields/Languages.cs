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
        public virtual FieldDTO DTO { get; set; }

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

        public static Languages GetLanguage(string language)
        {
            switch (language)
            {
                case nameof(Java):
                    return new Java();
                case nameof(CSharp):
                    return new CSharp();
                case nameof(Kotlin):
                    return new Kotlin();

                default:
                    return null;
            }

        }

        public void DTOtoBO(FieldDTO dto)
        {
            this.XP = dto.XP;
            this.Level = dto.Level;
            this.DTO = dto;
            
        }




    }


}
