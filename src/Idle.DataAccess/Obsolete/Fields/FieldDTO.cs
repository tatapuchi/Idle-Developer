using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Fields
{
    /// <summary>
    /// DTO for the field classes
    /// </summary>
    public class FieldDTO
    {
        public int XP { get; set; }
        /// <summary>
        /// Needed to distinguish what field this is
        /// </summary>
        public string Name { get; set; }
    }
}
