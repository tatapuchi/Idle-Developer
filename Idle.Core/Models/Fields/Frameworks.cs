using Idle.Core.Models.Player;
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

        //Methods regarding conversion of the framework to a DTO and vice versa
        #region DTO methods
        public void UpdateFromDTO(FieldDTO dto)
        {
            XP = dto.XP;
            Level = dto.Level;

        }

        public FieldDTO ConvertToDTO()
        {
            FieldDTO dto = new FieldDTO();
            dto.XP = XP;
            dto.Level = XP;

            return dto;

        }
        #endregion


    }

}
