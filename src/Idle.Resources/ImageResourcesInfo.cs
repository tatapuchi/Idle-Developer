﻿using Idle.Models.Fields.Languages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Idle.Resources
{
	internal static class Constants
	{
		internal const string AssemblyName = "Idle.Resources.";
		
	}

	internal static class Paths
	{
		public static string RootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Resources");
		public static string ImagesPath = Path.Combine(RootPath, "Images");
		public static string LanguageImagesPath = Path.Combine(ImagesPath, "Languages");

		public static IEnumerable<string> GetPaths { get; } = new List<string>()
		{
			RootPath, ImagesPath, LanguageImagesPath
		};
	}

	public class LanguageImagesProvider
	{
		private const string Images = Constants.AssemblyName + "Images.";
		private const string languages = Images + "Languages.";
		private const string cSharp = languages + "Csharp.png";
		private const string kotlin = languages + "Kotlin.png";

		public Dictionary<Type, ResourceNameAndPath> ResoucesAndPaths { get; } = new Dictionary<Type, ResourceNameAndPath>()
		{
			[typeof(CSharp)] = new ResourceNameAndPath(cSharp, Path.Combine(Paths.LanguageImagesPath, cSharp)),
			[typeof(Kotlin)] = new ResourceNameAndPath(cSharp, Path.Combine(Paths.LanguageImagesPath, kotlin))
		};
		
	}

	public class ResourceNameAndPath
	{
		public string ResourceName { get; }
		public string ResourcePath { get; }

		public ResourceNameAndPath(string resouceName, string resourcePath)
		{
			ResourceName = resouceName;
			ResourcePath = resourcePath;
		}
	}


	public class ImagesMigrator : IMigrator
	{
		private readonly LanguageImagesProvider _languageImagesProvider;

		public ImagesMigrator(LanguageImagesProvider languageImagesProvider)
		{
			_languageImagesProvider = languageImagesProvider;
		}

		public void Migrate()
		{
			CreateImagesIfNotExisting();
		}

		private void CreateImagesIfNotExisting()
		{
			var resourcesMapping = _languageImagesProvider.ResoucesAndPaths;

			foreach (var resourceMap in resourcesMapping)
			{
				var resourcePath = resourceMap.Value.ResourcePath;
				if (File.Exists(resourcePath)) continue;

				var resourceName = resourceMap.Value.ResourceName;
				var resourcesAssembly = Assembly.GetExecutingAssembly();

#if DEBUG
				var resources = resourcesAssembly.GetManifestResourceNames();
#endif

				using var resourceStream = resourcesAssembly.GetManifestResourceStream(resourceName);
				using var fileStream = File.Create(resourcePath);
				resourceStream.Seek(0, SeekOrigin.Begin);
				resourceStream.CopyTo(fileStream);
			}


		}
	}
}
