using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    //Example implementation of Languages abstract class
    public sealed class Java : Languages
    {
        public Java()
        {
            _dto = new FieldDTO { XP = _xp, Level = _level, };
        }


        private string _name = "Java";
        public override string Name { get => _name; set => _name = value; }

        private string _description = "A coffee language";
        public override string Description { get => _description; set => _description = value; }



        //Default amount of xp
        private int _xp = 0;
        public override int XP { get => _xp; set { _xp = value; _dto.XP = value; } }


        //Default level
        private int _level = 1;
        public override int Level { get => _level; set { _level = value; _dto.Level = value; } }

        private FieldDTO _dto = new FieldDTO();


        public override FieldDTO DTO { get => _dto; set => _dto = value; }
    }
}
