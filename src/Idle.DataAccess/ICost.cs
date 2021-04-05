using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// An interface that defines the cost of something
    /// </summary>
    public interface ICost
    {
        /// <summary>
        /// The cost of something, could be in coins (items are bought with coins), could be in player XP (languages/frameworks/tools are bought with player XP)
        /// </summary>
        public int Cost { get;}

    }
}
