namespace Idle.Common.Diagnostics
{
	internal class EmptyLoggerStrategy : ILogger
	{
		public void Log(LogLevel logLevel, LogMessage logMessage) { }
	}


}


