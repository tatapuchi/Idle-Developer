using Idle.Logic;

namespace Idle.Views.Common
{
	internal interface IViewModel<TViewModel>
        where TViewModel : ViewModelBase
	{
        TViewModel ViewModel { get; set; }
	}
}
