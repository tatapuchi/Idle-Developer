using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Common
{
    /// <summary>
    /// An enum defining the different levels of difficulty
    /// </summary>
    public enum Difficulty
    {
        /// <summary>
        /// If difficulty is not applicable
        /// </summary>
        None,
        /// <summary>
        /// Easy difficulty, examples would include HTML and CSS
        /// </summary>
        Easy,
        /// <summary>
        /// Medium difficulty, examples include JavaScript and Python
        /// </summary>
        Medium,
        /// <summary>
        /// Hard difficulty, examples include Java and C#
        /// </summary>
        Hard,
        /// <summary>
        /// Expert difficulty, examples include C and C++
        /// </summary>
        Expert,
        /// <summary>
        /// Nightmare difficulty, examples include x86 assembly
        /// </summary>
        Nightmare
    }
}
