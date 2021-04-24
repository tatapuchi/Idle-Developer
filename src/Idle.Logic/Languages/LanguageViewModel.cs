using Idle.DataAccess.Common;
using Idle.DataAccess.Migrators;
using Idle.DataAccess.Repositories;
using Idle.Models.Common;
using Idle.Models.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Logic.Languages
{
    public class LanguageViewModel : BaseViewModel
    {
        internal readonly Language _language;

        public LanguageViewModel(Language language)
        {
            _language = language;

            ImagePath = language.ImagePath;

            Name = language.Name;
            Description = language.Description;
            Difficulty = language.Difficulty;
            XPCost = language.XPCost;
            XPIncome = language.XPIncome;
        }

        public string ImagePath { get; }
        public string Name { get; }
        public string Description { get; }
        public Difficulty Difficulty { get; }
        public int XPCost { get; }
        public int XPIncome { get; }

        //Setting default value even though the value will be set in the constructor
        private int _xp = 0;
        public int XP 
        { 
            get { return _xp; } 
            private set 
            {
                _xp = value;

            //This part checks if the XP is high enough to increment the Level, this is needed in here as when we load data in from the db
            //we want to provide the language objects with only the XP, and then let the setters handle the updating of the Level and Grade
                while (_xp > (45 * Level))
                {

                    _xp -= (45 * Level);
                    Level++;
                }

                OnPropertyChanged(nameof(XP));
            } 
        }

        //Setting default value even though the value will be set in the constructor
        private int _level = 1;
        public int Level { 
            get { return _level; } 
            private set 
            {
                SetProperty(ref _level, value);

                //I prefer to use guard clause over if-else because its a lot easier to read this way and more concise
                if (value > 10) { Grade = "D"; }
                if (value > 20) { Grade = "C"; }
                if (value > 30) { Grade = "B"; }
                if (value > 40) { Grade = "A"; }
                if (value > 50) { Grade = "S"; }
                if (value > 100) { Grade = "S+"; }
                if (value > 200) { Grade = "S++"; }
            } 
        }

        private string _grade = "F";
        public string Grade 
        {
            get { return _grade; }
            private set => SetProperty(ref _grade, value); 
        }


        //Adds to XP based on the XPIncome property of the concretion
        public void GainXP()
        {
            XP += XPIncome;
        }

    }
}
