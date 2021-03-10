using Idle.Core.Models.Fields;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Idle.Core.ViewModels
{
    public class SessionPageVM : INotifyPropertyChanged
    {
        private ObservableCollection<Language> _languages;
        public ObservableCollection<Language> Languages { get { return _languages; } set { _languages = value; NotifyPropertyChanged(nameof(Languages)); } }

        private ObservableCollection<Framework> _frameworks;
        public ObservableCollection<Framework> Frameworks { get { return _frameworks; } set { _frameworks = value; NotifyPropertyChanged(nameof(Frameworks)); } }

        private ObservableCollection<Tool> _tools;
        public ObservableCollection<Tool> Tools { get { return _tools; } set { _tools = value; NotifyPropertyChanged(nameof(Tools)); } }
        public SessionPageVM()
        {
        }

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
    }
}
