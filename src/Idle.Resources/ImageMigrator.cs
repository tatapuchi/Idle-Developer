using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Idle.Resources
{
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

			var resourcesMapping = _languageImagesProvider.Resources;

			foreach (var resource in resourcesMapping)
			{
				var resourcePath = _languageImagesProvider.ResourceToPath(resource.Value);
				#if DEBUG
				if (File.Exists(resourcePath))
					File.Delete(resourcePath);
				#endif


				if (File.Exists(resourcePath)) continue;

				var resourceName = resource.Value;
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
