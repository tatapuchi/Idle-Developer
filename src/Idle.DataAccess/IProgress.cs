using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// Interface that defines properties for in game progression or levelling
    /// </summary>
    public interface IProgress
    {
        /// <summary>
        /// The amount of experience points the player has in something.
        /// Could refer to overall XP of the player, XP in a certain language/framework/tool, XP in his job, etc.
        /// </summary>
        public int XP { get; set; }

        /// <summary>
        /// The level the player has in something.
        /// Could refer to overall level of the player, level in a certain language/framework/tool, level in his job, etc.
        /// Should be increased when enough XP has been earned.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// The grade (rank) of the player in something.
        /// Shows the proficiency of the player overall, in a certain language/framework/tool, in his job, etc.
        /// Should be based on what level the player is at, sort of gives a ranking factor that makes the game more interesting that just plain levels.
        /// </summary>
        public string Grade { get; set; }
    }
}
