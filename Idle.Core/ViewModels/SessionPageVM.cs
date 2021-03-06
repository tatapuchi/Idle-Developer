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
        private ObservableCollection<Languages> _languages;
        public ObservableCollection<Languages> Languages { get { return _languages; } set { _languages = value; NotifyPropertyChanged(nameof(Languages)); } }
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
