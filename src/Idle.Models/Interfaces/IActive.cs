using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Models.Interfaces
{
    public interface IActive
    {
        /// <summary>
        /// Whether the field has been purchased or not
        /// </summary>
        public bool Active { get; set; }

    }
}
