using Idle.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Idle.ResourceAccess
{
	internal static class Constants
	{
		internal static string RootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Resources");
		internal static string ImagesPath = Path.Combine(RootPath, "Images");

		internal static IEnumerable<string> Paths = new List<string>()
		{
			RootPath, ImagesPath
		};
	}

	public interface IMigrator
	{
		public void Migrate();
	}

	public class FileSystemMigrator : IMigrator
	{
		public void Migrate()
		{
			CreateDirectoryIfNotExisting(Constants.Paths);
			CreateImagesIfNotExisting();
		}

		private static void CreateDirectoryIfNotExisting(IEnumerable<string> directories)
		{
			foreach (var directory in directories)
			{
				if (Directory.Exists(directory)) continue;
				Directory.CreateDirectory(directory);
			}
		}

		private static void CreateImagesIfNotExisting()
		{
			var resourcesAssembly = typeof(AssemblyInfo).Assembly;
			var resources = resourcesAssembly.GetManifestResourceNames();
		}
	}

	public class FileSystem
	{
		
	}
}
