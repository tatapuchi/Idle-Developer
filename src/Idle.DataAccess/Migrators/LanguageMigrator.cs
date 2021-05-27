using Idle.DataAccess.Common;
using SQLite;
using System.Linq;
using System.Collections.Generic;
using Idle.Models.Fields;
using Idle.Models.Fields.Languages;
using Idle.Models.Common;
using Idle.Resources;
using System.Threading.Tasks;

namespace Idle.DataAccess.Migrators
{
	public class LanguagesFactory
	{
		private readonly ImagesProvider _imagesProvider;

		public LanguagesFactory(ImagesProvider imagesProvider)
		{
			_imagesProvider = imagesProvider;
		}

		public IEnumerable<Language> CreateLanguages()
		{
			yield return CreateLanguage<CSharp>();
			yield return CreateLanguage<Java>();
			yield return CreateLanguage<Kotlin>();
			yield return CreateLanguage<Python>();
		}

		private T CreateLanguage<T>()
			where T : Language, new()
		{
			var language = new T();

			var resourceName = _imagesProvider.GetResourceNameOrFallBack<T>();
			language.ImagePath = resourceName;

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

		// for testing
		internal LanguageMigrator(LanguagesFactory languagesFactory, SQLiteAsyncConnection sQLiteAsyncConnection) : base(sQLiteAsyncConnection)
		{
			_languagesFactory = languagesFactory;
		}

		protected override string TableName => TableNames.Languages;

		public override async Task MigrateAsync()
		{
			await base.MigrateAsync();

			var languages = _languagesFactory.CreateLanguages();
			await InsertIfNotExisting(languages);
			
		}


		private async Task InsertIfNotExisting(IEnumerable<Language> languages)
		{
			var existingLanguages = await Connection.Table<Language>().ToListAsync();
			var toBeAdded = languages.Except(existingLanguages).ToList();

			if (toBeAdded.Count == 0)
				return;

			await Connection.InsertAllAsync(toBeAdded);
			
		}
	}
}
