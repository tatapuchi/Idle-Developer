using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields
{
    public abstract class Frameworks : Field
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int XP { get; set; }
        public virtual int Level { get; set; }
        public virtual FieldDTO DTO { get; set; }

        public static Frameworks GetFramework(Field.Framework framework)
        {
            switch (framework)
            {
                default:
                    return null;
            }

        }

        public static Frameworks GetFramework(string framework)
        {
            switch (framework)
            {
                default:
                    return null;
            }

        }

        public static bool IsFramework(string framework)
        {
            switch (framework)
            {
                default:
                    return false;
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
