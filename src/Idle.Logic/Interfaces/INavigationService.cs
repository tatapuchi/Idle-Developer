using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Idle.Logic.Interfaces
{
	public interface INavigationService
	{
		Task PopAsync(bool animated);
		Task PopModalAsync(bool animated);
		Task PopToRootAsync(bool animated);
		Task PushAsync<TViewModel>(bool animated)
			where TViewModel : ViewModelBase;
		Task PushModalAsync<TViewModel>(bool animated)
			where TViewModel : ViewModelBase;
	}
}
