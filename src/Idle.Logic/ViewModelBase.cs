using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Idle.Logic
{
	public class ViewModelBase : INotifyPropertyChanging, INotifyPropertyChanged
	{
		public event PropertyChangingEventHandler PropertyChanging;
		public event PropertyChangedEventHandler PropertyChanged;

		protected void SetProperty<T>(ref T backingField, in T value, [CallerMemberName] string propertyName = "")
		{
			if (EqualityComparer<T>.Default.Equals(backingField, value)) return;
			OnPropertyChanging(propertyName);
			backingField = value;
			OnPropertyChanged(propertyName);
		}

		protected virtual void OnPropertyChanging([CallerMemberName] string propertyName = "") =>
			PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
