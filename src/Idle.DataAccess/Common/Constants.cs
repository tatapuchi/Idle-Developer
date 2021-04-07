using System;
using System.IO;

namespace Idle.DataAccess.Common
{
	internal static class Constants
	{
        internal const string FileName = "idle.db3";
		internal static string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FileName);

		public static bool Flags { get; internal set; }
	}

	
}
