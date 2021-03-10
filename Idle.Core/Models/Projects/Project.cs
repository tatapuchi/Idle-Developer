using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using static Idle.Core.Models.Fields.IField;

namespace Idle.Core.Models.Projects
{
    public class Project : INotifyPropertyChanged
    {
        public Project()
        {
            Version = 1;
            Income = 500;
            Title = "Developer";
            Description = "A Job";
            Frameworks = FrameworkType.None;
            Languages = LanguageType.None;
            Tools = ToolType.None;
            Type = ProjectType.None;
        }

        //DTO Properties

        private int _version;
        public int Version { get { return _version; } set { _version = value; NotifyPropertyChanged(nameof(Version)); } }

        private int _income;
        public int Income { get { return _income; } set { _income = value; NotifyPropertyChanged(nameof(Income)); } }

        //BO Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public FrameworkType Frameworks { get; set; }
        public LanguageType Languages { get; set; }
        public ToolType Tools { get; set; }
        public ProjectType Type { get; set; }


        #region DTO System
        public void Update(ProjectDTO dto)
        {
            Income = dto.Income;
            Version = dto.Version;
        }

        public ProjectDTO Convert()
        {
            ProjectDTO dto = new ProjectDTO();
            dto.Income = Income;
            dto.Version = Version;

            return dto;

        }
        #endregion


        [Flags]
        public enum ProjectType : long
        {
            None = 0,
            OS = 1,
            Web_Browser = 1 << 1,
            Game = 1 << 2,
            App = 1 << 3,
            Website = 1 << 4
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
