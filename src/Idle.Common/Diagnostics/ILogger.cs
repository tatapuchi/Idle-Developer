using System.Collections.Generic;
using System.Diagnostics;

namespace Idle.Common.Diagnostics
{

	public interface ILogger
	{
		void Log(LogMessage logMessage);
	}


	internal class EmptyLoggerStrategy : ILogger
	{
		public void Log(LogMessage logMessage) { }
	}

	internal class ConsoleLoggerStrategy : ILogger
	{
		public void Log(LogMessage logMessage) => Debug.WriteLine(logMessage.ToString());
	}

	// todo: https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/xamarin 
	// and: https://www.msctek.com/xamarin-forms-logging-with-appcenter/
	// we will do this before deploying the app.
	// we would only have to implement the strategy and not change any other code
	//internal class AppCenetLoggerStrategy : ILogger
	//{
	//	public void Log(LogMessage logMessage)
	//	{
	//		throw new System.NotImplementedException();
	//	}
	//}

	public class Logger : ILogger
	{
		// facade pattern. we dont want to expose the strategies in other assemblies
		// thats why the strategies are internal
		// DI is not required because the logger used in another assembly will not be tested.
		// mocking is enabled because of coupling to an interface
		private readonly static IEnumerable<ILogger> _loggers = new List<ILogger>()
		{
			new EmptyLoggerStrategy(),
			new ConsoleLoggerStrategy(),
			// new AppCenetLoggerStrategy()
		};

		public void Log(LogMessage logMessage)
		{
			foreach (var logger in _loggers)
				logger.Log(logMessage);
		}
	}

	
}


