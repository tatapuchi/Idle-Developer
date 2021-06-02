﻿namespace Idle.Models
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
