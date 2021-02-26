using System;
using System.Collections;
using System.Text;

namespace Idle.Core.Models
{
    public class FieldDTO
    {
        //Cost or XP required to buy a field does not need to be part of the DTO, neither does name or description
        public int XP { get; set; }
        public int Level { get; set; }

    }
}
