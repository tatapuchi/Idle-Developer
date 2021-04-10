using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// Interface defining income in XP of the language/framework/tool, etc. (NOT player XP)
    /// </summary>
    public interface IXPIncome
    {
        /// <summary>
        /// Income in XP
        /// </summary>
        public int XPIncome { get; }
    }
}
