using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// Interface defining income in coins
    /// </summary>
    public interface ICoinIncome
    {
        /// <summary>
        /// Income in coins
        /// </summary>
        public int CoinIncome { get; }
    }
}
