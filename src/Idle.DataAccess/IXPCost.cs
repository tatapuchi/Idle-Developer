using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// An interface that defines the cost of something in XP
    /// </summary>
    public interface IXPCost
    {
        /// <summary>
        /// The cost of something in player XP (languages/frameworks/tools are bought with player XP)
        /// </summary>
        public int XPCost { get; }
    }
}
