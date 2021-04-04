
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Idle.Core.Fields
{
    /// <summary>
    /// Framework class that defines the structure of a framework
    /// </summary>
    public class Framework : INotifyPropertyChanged
    {
        /// <summary>
        /// The name of the framework
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this framework
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The cost in player XP to unlock this framework
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// The frameworks that are needed to be able to start learning this framework.
        /// </summary>
        public HashSet<string> Prerequisites { get; set; }

        private int _xp = 0;
        /// <summary>
        /// XP ín this framework, dictates the level of the framework
        /// </summary>
        public int XP
        {
            get { return _xp; }
            set
            {
                _xp = (int)(value * XPMult);
                while (_xp > (105 * Level))
                {
                    if (_xp > (105 * Level)) { Level++; XP -= (105 * Level); }
                }
                NotifyPropertyChanged(nameof(XP));
            }
        }

        private int _level = 1;
        /// <summary>
        /// Level in this framework, dictates the grade of the player
        /// </summary>
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                if (value > 25) { Grade = "D"; }
                if (value > 50) { Grade = "C"; }
                if (value > 75) { Grade = "B"; }
                if (value > 100) { Grade = "A"; }
                if (value > 200) { Grade = "S"; }
                if (value > 500) { Grade = "S+"; }
                if (value > 1000) { Grade = "S++"; }
            }
        }

        private string _grade = "F";

        /// <summary>
        /// The calibre of a developer in a framework, marked by a letter grade.
        /// These letters range from F to S++
        /// </summary>
        public string Grade { get { return _grade; } private set { _grade = value; } }

        private float _speedMult = 1f;
        /// <summary>
        /// The speed multiplier of a framework.
        /// Affects how fast you complete the learning session.
        /// </summary>
        public float SpeedMult { get { return _speedMult; } set { _speedMult = value; } }

        private float _xpMult = 1f;

        /// <summary>
        /// The XP multiplier of a framework.
        /// Affects how much the framework XP increase upon completion of a session.
        /// </summary>
        public float XPMult { get { return _xpMult; } set { _xpMult = value; } }

        /// <summary>
        /// Checks based on the players known languages, whether he can unlock this framework or not
        /// </summary>
        /// <param name="languages">string array of languages known</param>
        /// <returns>true or false, depending on whether the player can unlock this framework or not</returns>
        public bool IsAvailable(params string[] languages)
        {
            if (Prerequisites.IsSubsetOf(languages))
            {
                return true;
            }

            return false;
        }

        #region Constructors
        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public Framework()
        {
            Name = "Programming Language";
            Description = "A fast, statically typed, general purpose programming language";
            Cost = 50;
            Prerequisites = new HashSet<string>() { "HTML", "CSS", "JavaScript" };
        }

        /// <summary>
        /// Constructor that doesnt take in a DTO
        /// </summary>
        /// <param name="name">Name of the framework</param>
        /// <param name="description">Description of the framework</param>
        /// <param name="cost">Cost in player XP to unlock this framework</param>
        /// <param name="prerequisites">string array of language prerequisites</param>
        public Framework(string name, string description, int cost, params string[] prerequisites)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Prerequisites = new HashSet<string>(prerequisites);
        }

        /// <summary>
        /// Constructor that does take in a DTO
        /// </summary>
        /// <param name="dto">FieldDTO providing the values</param>
        /// <param name="name">Name of the framework</param>
        /// <param name="description">Description of the framework</param>
        /// <param name="cost">Cost in player XP to unlock this framework</param>
        /// <param name="prerequisites">string array of language prerequisites</param>
        public Framework(FieldDTO dto, string name, int cost, string description, params string[] prerequisites)
        {
            XP = dto.XP;
            Name = name;
            Description = description;
            Cost = cost;
            Prerequisites = new HashSet<string>(prerequisites);
        }
        #endregion

        #region DTO System
        /// <summary>
        /// Method to update the framework's values from a DTO
        /// </summary>
        /// <param name="dto">FieldDTO providing the values</param>
        public void Update(FieldDTO dto)
        {
            XP = dto.XP;
        }

        /// <summary>
        /// Method to convert language business object to a fieldDTO
        /// </summary>
        /// <returns>FieldDTO that we can store</returns>
        public FieldDTO Convert()
        {
            FieldDTO dto = new FieldDTO();
            dto.XP = XP;
            dto.Name = Name;

            return dto;

        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;


        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        #endregion

    }
}
