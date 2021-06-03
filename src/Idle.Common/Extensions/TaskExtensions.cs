using Idle.Common.Diagnostics;
using System;
using System.Threading.Tasks;

namespace Idle.Common.Extensions
{
	public static class TaskExtensions
	{
		// todo: pass logger via Method Injection
		public static async void AwaitAsync(this Task task, ILogger logger)
		{
			try
			{
				await AwaitAsyncImplementation(task);
			}
			catch (Exception e)
			{
				logger.Log(LogLevel.Error, new LogMessage(e));
				#if DEBUG
					throw;
				#endif
			}
		}

		private static async Task AwaitAsyncImplementation(Task task) => await task;
	}
}
