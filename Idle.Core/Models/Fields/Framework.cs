using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using static Idle.Core.Models.Fields.IField;

namespace Idle.Core.Models.Fields
{
    public class Framework : IField, INotifyPropertyChanged
    {
        public Framework()
        {
            XP = 0;
            Level = 0;
            Cost = 500;
            Name = "Framework";
            Description = "Useful Programming Framework";
            Type = FrameworkType.None;
        }

        //DTO Properties
        private int _xp;
        public int XP { get { return _xp; } set { _xp = value; NotifyPropertyChanged(nameof(XP)); } }

        private int _level;
        public int Level { get { return _level; } set { _level = value; NotifyPropertyChanged(nameof(Level)); } }

        //BO Properties
        public int Cost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FrameworkType Type { get; set; }
        public LanguageType Prerequisites { get; set; }


        #region DTO System
        public void Update(FieldDTO dto)
        {
            XP = dto.XP;
            Level = dto.Level;

        }

        public FieldDTO Convert()
        {
            FieldDTO dto = new FieldDTO();
            dto.XP = XP;
            dto.Level = Level;

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
