using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Field;

namespace Idle.Core.Models
{
    public class FieldDTO
    {
        //Cost or XP required to buy a field does not need to be part of the DTO, neither does name or description
        public int XP { get; set; }
        public int Level { get; set; }
    }
}
