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
		Task<TViewModel> PushAsync<TViewModel>(bool animated)
			where TViewModel : ViewModelBase;
		Task<TViewModel> PushModalAsync<TViewModel>(bool animated)
			where TViewModel : ViewModelBase;
	}
}
