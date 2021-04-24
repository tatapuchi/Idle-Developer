using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Models
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
