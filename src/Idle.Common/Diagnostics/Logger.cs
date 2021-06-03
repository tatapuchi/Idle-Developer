using System;
using System.Collections.Generic;

namespace Idle.Common.Diagnostics
{
	public class Logger : ILogger
	{
		// singleton
		private Logger(){ }
		
		private static readonly Lazy<ILogger> _instance = new Lazy<ILogger>(() => new Logger());
		public static ILogger Instance => _instance.Value;

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

		public void Log(LogLevel logLevel, LogMessage logMessage)
		{
			foreach (var logger in _loggers)
				logger.Log(logLevel, logMessage);
			
		}
	}


}


