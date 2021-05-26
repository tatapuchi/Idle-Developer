using Idle.DataAccess.Common;
using Idle.DataAccess.Migrators;
using Idle.DataAccess.Repositories;
using Idle.Logic.Common;
using Idle.Logic.Interfaces;
using Idle.Models.Common;
using Idle.Models.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Idle.Logic.Languages
{
    public class LanguageViewModel : ViewModelBase
    {
        internal readonly Language _language;

        public LanguageViewModel(Language language) 
            : this()
        {
            _language = language;

			Progress = language.Progress;
            XP = language.XP;
            Level = language.Level;
            Grade = language.Grade;
        }

		private LanguageViewModel()
		{
            GainProgressCommand = new Command(_ => Progress += 0.2f);
        }

        
		public ICommand GainProgressCommand { get; }

        #region Props

        public string ImagePath { get => _language.ImagePath; }
        public string Name { get => _language.Name; }
        public string Description { get => _language.Description; }
        public Difficulty Difficulty { get => _language.Difficulty; }
        public int XPCost { get => _language.XPCost; }
        public int XPIncome { get => _language.XPIncome; }

        //Setting default value even though the value will be set in the constructor
        public int XP
		{
			get => _language.XP;

			private set
			{
				if (!TrySetProperty(value => _language.XP = value, () => _language.XP, value)) return;

				var lvlingAmount = LevellingAmount();

				//This part checks if the XP is high enough to increment the Level, this is needed in here as when we load data in from the db
				//we want to provide the language objects with only the XP, and then let the setters handle the updating of the Level and Grade
				while (_language.XP > lvlingAmount)
				{
					_language.XP -= lvlingAmount;
					Level++;
				}
			}
		}

		//Setting default value even though the value will be set in the constructor
        public int Level
		{
			get => _language.Level;
			private set
			{
				if (!TrySetProperty(value => _language.Level = value, () => _language.Level, value)) return;

				//I prefer to use guard clause over if-else because its a lot easier to read this way and more concise
				if (value > 5) { Grade = "D"; }
				if (value > 10) { Grade = "C"; }
				if (value > 20) { Grade = "B"; }
				if (value > 30) { Grade = "A"; }
				if (value > 40) { Grade = "S"; }
				if (value > 50) { Grade = "S+"; }
				if (value > 100) { Grade = "S++"; }
			}
		}

        public string Grade
		{
			get { return _language.Grade; }
            set{ TrySetProperty(value => _language.Grade = value, () => _language.Grade, value);}
		}

		// The progress of our progress bar in the view
        public float Progress
		{
			get => _language.Progress;
			set
			{
				if (!TrySetProperty(value => _language.Progress = value, () => _language.Progress, value)) return;
				if (_language.Progress >= 1f)
				{
					_language.Progress = 0f;
					GainXP();
				}
			}
		}

		#endregion Props


		//Adds to XP based on the XPIncome property of the concretion
		private void GainXP()
        {
            XP += XPIncome;
        }
        
        //This will change once multipliers have been introduced
        private int LevellingAmount()
        {
            int amount = 25;
            amount *= (int) (1 + (Level * 0.1));
            return amount;
        }

    }
}
