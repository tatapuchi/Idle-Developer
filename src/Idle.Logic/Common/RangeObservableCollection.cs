using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Idle.Logic.Common
{
	public class RangeObservableCollection<T> : ObservableCollection<T>
		where T : notnull
	{
		public void AddRange(params T[] items) => 
			AddRange((IEnumerable<T>)items);

		public void AddRange(IEnumerable<T> items)
		{
			foreach (var item in items)
				Add(item);
		}

		
	}
}
