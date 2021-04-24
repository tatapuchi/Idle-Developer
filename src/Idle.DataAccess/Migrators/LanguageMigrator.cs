using Idle.DataAccess.Common;
using SQLite;
using System.Linq;
using System.Collections.Generic;
using Idle.Models.Fields;
using Idle.Models.Fields.Languages;
using Idle.Models.Common;
using Idle.Resources;

namespace Idle.DataAccess.Migrators
{
	public class LanguagesFactory
	{
		private readonly LanguageImagesProvider _languageImagesProvider;

		public LanguagesFactory(LanguageImagesProvider languageImageProvider)
		{
			_languageImagesProvider = languageImageProvider;
		}

		public IEnumerable<Language> CreateLanguages()
		{
			yield return CreateLanguage<CSharp>();
			yield return CreateLanguage<Java>();
			yield return CreateLanguage<Kotlin>();
		}

		private T CreateLanguage<T>()
			where T : Language, new()
		{
			var language = new T();

			var imageInfo = _languageImagesProvider.GetResourceInfoOrFallback(typeof(T));
			language.ImagePath = imageInfo.ResourcePath;

			return language;
		}
	}

	public class LanguageMigrator : MigratorBase<Language>
	{
		private readonly LanguagesFactory _languagesFactory;

		public LanguageMigrator(LanguagesFactory languagesFactory) 
		{
			_languagesFactory = languagesFactory;
		}
		// For testing
		internal LanguageMigrator(string path) : base(path) { }
		protected override string TableName => TableNames.Languages;

		public override void Migrate()
		{
			base.Migrate();

			var languages = _languagesFactory.CreateLanguages();

			InsertIfNotExisting(languages);
			
		}


		private void InsertIfNotExisting(IEnumerable<Language> languages)
		{
			var existingLanguages = Connection.Table<Language>().ToList();
			var toBeAdded = languages.Except(existingLanguages).ToList();

			if (toBeAdded.Count == 0)
				return;

			foreach (var language in toBeAdded)
			{
				Connection.Insert(language);
			}
			
		}
	}
}
