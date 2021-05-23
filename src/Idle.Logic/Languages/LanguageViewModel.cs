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
    // https://forums.xamarin.com/discussion/39438/is-there-the-indeterminate-attribute-for-the-progressbar-in-xamarin-forms
    public class LanguageViewModel : ViewModelBase, IImage
    {
        internal readonly Language _language;
        private readonly IMainThreadService _mainThreadService;

        public LanguageViewModel(Language language, IMainThreadService mainThreadService) 
            : this()
        {
            _language = language;
            _mainThreadService = mainThreadService;

            ImagePath = language.ImagePath;
            Name = language.Name;
            Description = language.Description;
            Difficulty = language.Difficulty;
            XPCost = language.XPCost;
            XPIncome = language.XPIncome;
        }

		private LanguageViewModel()
		{
            GainProgressCommand = new Command(_ => Progress += 0.2f);

          
        }

        

		public ICommand GainProgressCommand { get; }

        #region Model-props

        public string ImagePath { get; }
        public string Name { get; }
        public string Description { get; }
        public Difficulty Difficulty { get; }
        public int XPCost { get; }
        public int XPIncome { get; }

        #endregion Model-props

        #region Props

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
                while (_xp > (25 * Level))
                {

                    _xp -= (25 * Level);
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
                _level = value;
                //SetProperty(ref _level, value);

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
            set { _grade = value; OnPropertyChanged(nameof(Grade)); }
            //private set => SetProperty(ref _grade, value); 
        }

        // The progress of our progress bar in the view
        private float _progress = 0.0f;
        public float Progress 
        { 
            get { return _progress; } 
            set 
            {
                _progress = value;
                if (_progress >= 1f) { _progress = 0f; GainXP(); }
                OnPropertyChanged(nameof(Progress));
            } 
        }

        #endregion Props


        //Adds to XP based on the XPIncome property of the concretion
        public void GainXP()
        {
            XP += XPIncome;
        }


        //private async void GainProgressAsyncWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        await GainProgressWorkAsyncImpl();
        //    }
        //    catch (Exception)
        //    {
        //        // todo use logging
        //        throw;
        //    }
        //}

        //private async Task GainProgressWorkAsyncImpl()
        //{
        //    await _mainThreadService.InvokeOnMainThreadAsync(async () =>
        //    {
        //        while (true)
        //        {
        //            Progress += 0.005f;
        //            await Task.Delay(50);
        //        };
        //    });
        //}

		//public void Dispose()
		//{
  //          if (_isDisposed) return;
  //          _progressTimer.Stop();
		//}
	}
}
