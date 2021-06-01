using Idle.DataAccess.Common;
using SQLite;
using System.Linq;
using System.Collections.Generic;
using Idle.Models.Common;
using System.Threading.Tasks;
using Idle.Models.Models;
using Idle.DataAccess.ModelTemplates.Languages;
using System;

namespace Idle.DataAccess.Migrators
{
	public class LanguagesFactory
	{
		public IEnumerable<Language> CreateLanguages()
		{
			yield return new CSharp();
			yield return new Java();
			yield return new Kotlin();
			yield return new Python();
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
			await InsertIfNotExistingAsync(languages);
			
		}


		private async Task InsertIfNotExistingAsync(IEnumerable<Language> languages)
		{
			var existingLanguages = await Connection.Table<Language>().ToListAsync();
			var toBeAdded = languages.Except(existingLanguages).ToList();

			if (toBeAdded.Count == 0)
				return;

			await Connection.InsertAllAsync(toBeAdded);
			
		}
	}
}
