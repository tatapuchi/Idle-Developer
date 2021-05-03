using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Idle.Resources.Common
{
	internal static class Paths
	{
		public static string RootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Resources");
		public static string ImagesPath = Path.Combine(RootPath, "Images");
		public static string LanguageImagesPath = Path.Combine(ImagesPath, "Languages");

		public static IEnumerable<string> GetPaths 
		{ 
			get 
			{ 
				yield return RootPath;
				yield return ImagesPath;
				yield return LanguageImagesPath;
			} 
		}

	}

}
