using System;
using System.Threading.Tasks;

namespace Idle.Common.Extensions
{
	public static class TaskExtensions
	{
		// todo: pass logger via Method Injection
		public static async void AwaitAsync(this Task task)
		{
			try
			{
				await AwaitAsyncImplementation(task);
			}
			catch (Exception e)
			{
				// todo: add logging
				throw;
			}
		}

		private static async Task AwaitAsyncImplementation(Task task) => await task;
	}
}
