using Idle.Logic;
using Idle.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Idle.Services
{
	

	// note: removepage and insertpage methods are ot implemented yet
	public class NavigationService : INavigationService
	{
		private readonly Lazy<INavigation> _navigation;
		private static readonly Dictionary<Type, Func<Page>> _pageFactories = new Dictionary<Type, Func<Page>>();

		public NavigationService(Lazy<INavigation> navigation)
		{
			_navigation = navigation;
		}

		private INavigation Navigation => _navigation.Value;

		public void Register<TViewModel>(Func<Page> pageFactory)
			where TViewModel : ViewModelBase =>
			_pageFactories[typeof(TViewModel)] = pageFactory;


		public Task PushAsync<TViewModel>(bool animated)
			where TViewModel : ViewModelBase
		{
			var page = GetPage<TViewModel>();
			return Navigation.PushAsync(page, animated);
		}

		public Task PushModalAsync<TViewModel>(bool animated)
			where TViewModel : ViewModelBase
		{
			var page = GetPage<TViewModel>();
			return Navigation.PushModalAsync(page, animated);
		}

		public Task PopAsync(bool animated) => Navigation.PopAsync(animated);

		public Task PopModalAsync(bool animated) => Navigation.PopModalAsync(animated);

		public Task PopToRootAsync(bool animated) => Navigation.PopToRootAsync(animated);

		private static Page GetPage<TViewModel>()
			where TViewModel : ViewModelBase
		{
			var pageFactory = _pageFactories[typeof(TViewModel)];
			var page = pageFactory.Invoke();
			return page;
		}
	}
}
