using System;
using System.Collections.Generic;
using System.Text;


namespace Idle.Core.Models.Fields
{
    public abstract class Tools : Field
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int XP { get; set; }
        public virtual int Level { get; set; }


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
            dto.Level = Level;

            return dto;

        }
        #endregion
    }
}
