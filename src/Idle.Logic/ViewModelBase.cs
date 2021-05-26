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

		protected bool TrySetProperty<T>(ref T backingField, in T value, [CallerMemberName] string propertyName = "")
		{
			if (EqualityComparer<T>.Default.Equals(backingField, value)) return false;
			OnPropertyChanging(propertyName);
			backingField = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		protected bool TrySetProperty<T>(Action<T> setProp, Func<T> getProp, in T value, [CallerMemberName] string propertyName = "")
        {
			T x = getProp.Invoke();
			if (EqualityComparer<T>.Default.Equals(x, value)) return false;
			//if (x.Equals(value)) { return false; }
			OnPropertyChanging(propertyName);
			setProp.Invoke(value);
			OnPropertyChanged(propertyName);
			return true;
        }

		protected virtual void OnPropertyChanging([CallerMemberName] string propertyName = "") =>
			PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
