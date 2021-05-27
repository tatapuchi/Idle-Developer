using Idle.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using static Xamarin.Essentials.MainThread;

namespace Idle.Services
{
	public class MainThreadService : IMainThreadService
	{

		public bool IsMainThread => Xamarin.Essentials.MainThread.IsMainThread;

		public Task<SynchronizationContext> GetMainThreadSynchronizationContextAsync() =>
			Xamarin.Essentials.MainThread.GetMainThreadSynchronizationContextAsync();

		public void BeginInvokeOnMainThread(Action action) =>
			Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(action);

		#region InvokeOnMainThreadAsync
		public Task InvokeOnMainThreadAsync(Action action) =>
			Xamarin.Essentials.MainThread.InvokeOnMainThreadAsync(action);

		public Task InvokeOnMainThreadAsync(Func<Task> funcTask) =>
			Xamarin.Essentials.MainThread.InvokeOnMainThreadAsync(funcTask);

		public Task<T> InvokeOnMainThreadAsync<T>(Func<T> func) =>
			Xamarin.Essentials.MainThread.InvokeOnMainThreadAsync(func);

		public Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> funcTask) =>
			Xamarin.Essentials.MainThread.InvokeOnMainThreadAsync(funcTask);
		#endregion InvokeOnMainThreadAsync



	}
}
