using System.Diagnostics;

namespace Idle.Common.Diagnostics
{
	internal class ConsoleLoggerStrategy : ILogger
	{
		public void Log(LogLevel logLevel, LogMessage logMessage)
		{
			logMessage.LogLevel = logLevel;
			Debug.WriteLine(logMessage.ToString());
		}
	}

	// todo: https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/xamarin 
	// and: https://www.msctek.com/xamarin-forms-logging-with-appcenter/
	// probably have to make the common assembly a multi target assembly
	// we will do this before deploying the app.
	// we would only have to implement the strategy and not change any other code
	//internal class AppCenetLoggerStrategy : ILogger
	//{
	//	public void Log(LogMessage logMessage)
	//	{
	//		throw new System.NotImplementedException();
	//	}
	//}

}


