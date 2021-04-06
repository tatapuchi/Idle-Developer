using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// An interface that defines the cost of something in coins
    /// </summary>
    public interface ICoinCost
    {
        /// <summary>
        /// The cost of something in coins (Items are bought with coins)
        /// </summary>
        public int CoinCost { get; }
    }
}
