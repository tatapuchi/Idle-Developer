using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core
{

    /// <summary>
    /// Player Class.
    /// Everything happens here.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Player's name
        /// </summary>
        public string Username { get; set; }

        private int _xp = 0;
        /// <summary>
        /// XP of the player, dictates the level of the player
        /// </summary>
        public int XP 
        {
            get { return _xp; }
            set 
            {
                _xp = value;
                while (_xp > (35 * Level))
                {
                    if (_xp > (35 * Level)) { Level++; XP -= (35 * Level); }
                }
            }
        }

        private int _level = 1;
        /// <summary>
        /// Level of the player, dictates the grade of the player
        /// </summary>
        public int Level 
        { 
            get { return _level; } 
            set 
            {
                _level = value;
                if(value > 5) { Grade = "D"; }
                if (value > 10) { Grade = "C"; }
                if (value > 15) { Grade = "B"; }
                if (value > 20) { Grade = "A"; }
                if (value > 25) { Grade = "S"; }
                if (value > 50) { Grade = "S+"; }
                if (value > 100) { Grade = "S++"; }
            } 
        }

        /// <summary>
        /// Number of coins the player has (In-Game Currency)
        /// </summary>
        public int Coins { get; set; }

        private string _grade = "F";
        /// <summary>
        /// The calibre of a developer, marked by a letter grade.
        /// These letters range from F to S++
        /// </summary>
        public string Grade { get { return _grade; } private set { _grade = value; } }

        /// <summary>
        /// The speed multiplier of a player.
        /// Affects how fast you complete a learning or job session.
        /// This is an overall multiplier, that applies to all sessions
        /// </summary>
        public float SpeedMult { get; set; }

        /// <summary>
        /// The XP multiplier of a player.
        /// Affects how much the player XP increases as you level up in a field.
        /// This does not affect how much XP is earned from field sessions.
        /// </summary>
        public float XPMult { get; set; }

        /// <summary>
        /// Basic Constructor that takes in no arguments.
        /// Sets username to a default value.
        /// </summary>
        public Player()
        {
            Username = "0xB01b";
        }

        /// <summary>
        /// Constructor that takes in a DTO to assign values.
        /// </summary>
        public Player(PlayerDTO dto)
        {
            Username = dto.Username;
            XP = dto.XP;
            Coins = dto.Coins;
        }


        /// <summary>
        /// Overriden ToString() method
        /// </summary>
        /// <returns>Returns a formatted string containing the players fields, items, coins, xp, level, etc.</returns>
        public override string ToString()
        {
            string playerData = Username;
            playerData += $"\n Grade: {Grade} | XP: {XP} | Level: {Level}";
            playerData += $"\n Coins: {Coins}";
            return playerData;
        }


    }
}
