using System;
using System.Threading;
using System.Threading.Tasks;

namespace Idle.Logic.Interfaces
{
	public interface IMainThreadService
	{
		bool IsMainThread { get; }

		void BeginInvokeOnMainThread(Action action);
		Task<SynchronizationContext> GetMainThreadSynchronizationContextAsync();
		Task InvokeOnMainThreadAsync(Action action);
		Task InvokeOnMainThreadAsync(Func<Task> funcTask);
		Task<T> InvokeOnMainThreadAsync<T>(Func<T> func);
		Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> funcTask);
	}
}