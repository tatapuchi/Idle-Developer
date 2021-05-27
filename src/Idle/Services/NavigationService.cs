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


		public async Task<TViewModel> PushAsync<TViewModel>(bool animated = true)
			where TViewModel : ViewModelBase
		{
			var page = await GetPageAsync<TViewModel>();
			await Navigation.PushAsync(page, animated);
			var vm = (TViewModel)page.BindingContext;
			return vm;
		}

		public async Task<TViewModel> PushModalAsync<TViewModel>(bool animated = true)
			where TViewModel : ViewModelBase
		{
			var page = await GetPageAsync<TViewModel>();
			await Navigation.PushModalAsync(page, animated);
			var vm = (TViewModel)page.BindingContext;
			return vm;
		}

		public Task PopAsync(bool animated = true) => Navigation.PopAsync(animated);

		public Task PopModalAsync(bool animated = true) => Navigation.PopModalAsync(animated);

		public Task PopToRootAsync(bool animated = true) => Navigation.PopToRootAsync(animated);

		private static async Task<Page> GetPageAsync<TViewModel>()
			where TViewModel : ViewModelBase
		{
			var pageFactory = _pageFactories[typeof(TViewModel)];
			var page = pageFactory.Invoke();
			var vm = (TViewModel)page.BindingContext;

			if (vm is IAsyncInit initAsync)
				await initAsync.InitializeAsync();
			
			return page;
		}
	}
}
