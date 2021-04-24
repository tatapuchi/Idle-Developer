//using Idle.Models.Fields.Languages;
//using Idle.Resources;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Idle.ResourceAccess
//{
//	internal static class Constants
//	{
//		internal static string RootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Resources");
//		internal static string ImagesPath = Path.Combine(RootPath, "Images");
//		internal static string LanguageImagesPath = Path.Combine(ImagesPath, "Languages");


//		internal static IEnumerable<string> Paths = new List<string>()
//		{
//			RootPath, ImagesPath, LanguageImagesPath
//		};
//	}

//	public interface IMigrator
//	{
//		public void Migrate();
//	}


//	public class ResourceAccessMigarator : IMigrator
//	{
//		private readonly DirectoryMigrator _directoryMigrator;
//		private readonly ImagesMigrator _imagesMigrator;

//		public ResourceAccessMigarator(DirectoryMigrator directoryMigrator, ImagesMigrator imagesMigrator)
//		{
//			_directoryMigrator = directoryMigrator;
//			_imagesMigrator = imagesMigrator;
//		}

//		public void Migrate()
//		{
//			_directoryMigrator.Migrate();
//			_imagesMigrator.Migrate();
//		}
//	}

//	public class DirectoryMigrator : IMigrator
//	{
//		public void Migrate()
//		{
//			CreateDirectoryIfNotExisting(Constants.Paths);
//		}

//		private static void CreateDirectoryIfNotExisting(IEnumerable<string> directories)
//		{
//			foreach (var directory in directories)
//			{
//				if (Directory.Exists(directory)) continue;
//				Directory.CreateDirectory(directory);
//			}
//		}
//	}


//	public class ImageResourcePathProvider
//	{
//		private readonly ImageResourcesInfo _imageResourcesInfo;

//		public ImageResourcePathProvider(ImageResourcesInfo imageResourcesInfo)
//		{
//			_imageResourcesInfo = imageResourcesInfo;
//		}

//		public Dictionary<string, string> GetMapping 
//		{
//			get
//			{
//				var resourceNames = _imageResourcesInfo.GetResouceNames();

//				// this creates a dictionary where the key is the embedded resource name and the value is the path of the resource
//				var resourcesMapping = resourceNames.ToDictionary(resourceName => resourceName, resourceName => Path.Combine(Constants.LanguageImagesPath, resourceName));
//				return resourcesMapping;
//			} 
//		}
//	}

//	public class ImagesMigrator : IMigrator
//	{
//		private readonly ImageResourcePathProvider _imageResourcePathProvider;

//		public ImagesMigrator(ImageResourcePathProvider imageResourcePathProvider)
//		{
//			_imageResourcePathProvider = imageResourcePathProvider;
//		}

//		public void Migrate()
//		{
//			CreateImagesIfNotExisting();
//		}

//		private void CreateImagesIfNotExisting()
//		{
//			var resourcesMapping = _imageResourcePathProvider.GetMapping;
			
//			foreach (var resourceMap in resourcesMapping)
//			{
//				var resourcePath = resourceMap.Value;
//				if (File.Exists(resourcePath)) continue;

//				var resourceName = resourceMap.Key;
//				var resourcesAssembly = typeof(ImageResourcesInfo).Assembly;

//				#if DEBUG
//					var resources = resourcesAssembly.GetManifestResourceNames();
//				#endif

//				using var resourceStream = resourcesAssembly.GetManifestResourceStream(resourceName);
//				using var fileStream = File.Create(resourcePath);
//				resourceStream.Seek(0, SeekOrigin.Begin);
//				resourceStream.CopyTo(fileStream);
//			}

			
//		}
//	}

//}
