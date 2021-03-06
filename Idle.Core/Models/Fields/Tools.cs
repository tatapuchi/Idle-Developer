using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace Idle.Core.Models.Fields
{
    public abstract class Tools : Field, INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private int _xp;
        public int XP { get { return _xp; } set { _xp = value; NotifyPropertyChanged(nameof(XP)); } }

        private int _level;
        public int Level { get { return _level; } set { _level = value; NotifyPropertyChanged(nameof(Level)); } }


        //Methods regarding conversion of the framework to a DTO and vice versa
        #region DTO methods
        public void UpdateFromDTO(FieldDTO dto)
        {
            XP = dto.XP;
            Level = dto.Level;

        }

        public FieldDTO ConvertToDTO()
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
