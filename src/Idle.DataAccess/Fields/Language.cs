using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Idle.Core.Fields
{
    /// <summary>
    /// Language class that defines the structure of a language
    /// </summary>
    public class Language: INotifyPropertyChanged
    {
        /// <summary>
        /// The name of the language
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this language
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The cost in player XP to unlock this language
        /// </summary>
        public int Cost { get; set; }

        private int _xp = 0;
        /// <summary>
        /// XP ín this language, dictates the level of the language
        /// </summary>
        public int XP
        {
            get { return _xp; }
            set
            {
                _xp = (int)(value * XPMult);
                while (_xp > (85 * Level))
                {
                    if (_xp > (85 * Level)) { Level++; XP -= (85 * Level); }
                }
                NotifyPropertyChanged(nameof(XP));
            }
        }

        private int _level = 1;
        /// <summary>
        /// Level in this language, dictates the grade of the player
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
        /// The calibre of a developer in a language, marked by a letter grade.
        /// These letters range from F to S++
        /// </summary>
        public string Grade { get { return _grade; } private set { _grade = value; } }

        private float _speedMult = 1f;
        /// <summary>
        /// The speed multiplier of a language.
        /// Affects how fast you complete the learning session.
        /// </summary>
        public float SpeedMult { get { return _speedMult; } set { _speedMult = value; } }

        private float _xpMult = 1f;

        /// <summary>
        /// The XP multiplier of a language.
        /// Affects how much the language XP increase upon completion of a session.
        /// </summary>
        public float XPMult { get { return _xpMult; } set { _xpMult = value; } }


        #region Constructors
        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public Language()
        {
            Name = "Programming Language";
            Description = "A fast, statically typed, general purpose programming language";
            Cost = 50;
        }

        /// <summary>
        /// Constructor that doesnt take in a DTO
        /// </summary>
        /// <param name="name">Name of the language</param>
        /// <param name="description">Description of the language</param>
        /// <param name="cost">Cost in player XP to unlock this language</param>
        public Language(string name, int cost, string description)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }

        /// <summary>
        /// Constructor that does take in a DTO
        /// </summary>
        /// <param name="dto">FieldDTO providing the values</param>
        /// <param name="name">Name of the language</param>
        /// <param name="description">Description of the language</param>
        /// <param name="cost">Cost in player XP to unlock this language</param>
        public Language(FieldDTO dto, string name, int cost, string description)
        {
            XP = dto.XP;
            Name = name;
            Description = description;
            Cost = cost;
        }
        #endregion

        #region DTO System
        /// <summary>
        /// Method to update the language's values from a DTO
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
