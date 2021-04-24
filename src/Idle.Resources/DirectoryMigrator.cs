using System.Collections.Generic;
using System.IO;

namespace Idle.Resources
{
	public class DirectoryMigrator : IMigrator
	{
		public void Migrate()
		{
			CreateDirectoryIfNotExisting(Paths.GetPaths);
		}

		private static void CreateDirectoryIfNotExisting(IEnumerable<string> directories)
		{
			foreach (var directory in directories)
			{
				if (Directory.Exists(directory)) continue;
				Directory.CreateDirectory(directory);
			}
		}
	}
}
