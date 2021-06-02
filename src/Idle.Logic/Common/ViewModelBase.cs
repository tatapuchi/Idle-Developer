using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Idle.Logic.Common
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

		protected virtual void OnPropertyChanging([CallerMemberName] string propertyName = "") =>
			PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
