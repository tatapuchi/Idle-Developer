using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using static Idle.Core.Models.Fields.IField;

namespace Idle.Core.Models.Jobs
{
    public class Job : INotifyPropertyChanged
    {
        public Job()
        {
            XP = 0;
            Level = 0;
            Salary = 500;
            Title = "Developer";
            Description = "A Job";
            Frameworks = FrameworkType.None;
            Languages = LanguageType.None;
            Tools = ToolType.None;
            Type = JobType.None;
        }

        //DTO Properties
        private int _xp;
        public int XP { get { return _xp; } set { _xp = value; NotifyPropertyChanged(nameof(XP)); } }

        private int _level;
        public int Level { get { return _level; } set { _level = value; NotifyPropertyChanged(nameof(Level)); } }

        private int _salary;
        public int Salary { get { return _salary; } set { _salary = value; NotifyPropertyChanged(nameof(Salary)); } }

        //BO Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public FrameworkType Frameworks { get; set; }
        public LanguageType Languages { get; set; }
        public ToolType Tools { get; set; }
        public JobType Type { get; set; }


        #region DTO System
        public void Update(JobDTO dto)
        {
            XP = dto.XP;
            Level = dto.Level;
            Salary = dto.Salary;
        }

        public JobDTO Convert()
        {
            JobDTO dto = new JobDTO();
            dto.XP = XP;
            dto.Level = Level;
            dto.Salary = Salary;

            return dto;

        }
        #endregion


        [Flags]
        public enum JobType : long
        {
            None = 0,
            Junior_Developer = 1,
            Senior_Developer = 1 << 1,
            Tester = 1 << 2,
            Youtuber = 1 << 3,
            Bloger = 1 << 4
        }


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
