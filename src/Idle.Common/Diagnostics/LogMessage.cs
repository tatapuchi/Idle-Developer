using System;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable

namespace Idle.Common.Diagnostics
{
	public class LogMessage
	{
		private const string _logPrefix = "### ";

		public LogMessage(
			[CallerMemberName] string callerName = null,
			[CallerFilePath] string filePath = null,
			[CallerLineNumber] int? lineNumber = null)
		{
			CallerName = callerName;
			FilePath = filePath;
			LineNumber = lineNumber;
		}

		public LogMessage(
			Exception exception,
			[CallerMemberName] string callerName = null,
			[CallerFilePath] string filePath = null,
			[CallerLineNumber] int? lineNumber = null)
		: this(callerName, filePath, lineNumber)
		{
			Exception = exception;
		}

		public LogMessage(
			string message,
			[CallerMemberName] string callerName = null,
			[CallerFilePath] string filePath = null,
			[CallerLineNumber] int? lineNumber = null)
		: this(callerName, filePath, lineNumber)
		{
			Message = message;
		}

		public LogMessage(
			Exception exception,
			string message,
			[CallerMemberName] string callerName = null,
			[CallerFilePath] string filePath = null,
			[CallerLineNumber] int? lineNumber = null)
		: this(callerName, filePath, lineNumber)
		{
			Exception = exception;
			Message = message;
		}

		// diagnostics
		public string? CallerName { get; }
		public string? FilePath { get; }
		public int? LineNumber { get; }

		public string? Message { get; }
		public Exception? Exception { get; }
		public LogLevel LogLevel { get; internal set; }

		public override string ToString()
		{
			const string logLevel = nameof(LogLevel);
			const string message = nameof(Message);
			const string exception = nameof(Exception);
			const string callerName = nameof(CallerName);
			const string filePath = nameof(FilePath);
			const string lineNumber = nameof(LineNumber);

			var sb = new StringBuilder(_logPrefix);
			AppendIfNotNull(sb, logLevel, LogLevel);
			AppendIfNotNull(sb, message, Message);
			AppendIfNotNull(sb, exception, Exception);
			AppendIfNotNull(sb, callerName, CallerName);
			AppendIfNotNull(sb, filePath, FilePath);
			AppendIfNotNull(sb, lineNumber, LineNumber);

			return sb.ToString();
		}

		private static void AppendIfNotNull(StringBuilder sb, string prefix, object? value)
		{
			if (value != null)
				sb.Append(prefix).Append(value).Append(Environment.NewLine);
		}
	}
}

#nullable disable
