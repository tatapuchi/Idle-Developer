using SQLite;
using System.Linq;
using System.Collections.Generic;
using Idle.Models.Common;
using System.Threading.Tasks;
using Idle.Models.Models;
using Idle.DataAccess.ModelTemplates.Languages;
using Idle.Common.Diagnostics;

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
		private readonly ILogger _logger;

		public LanguageMigrator(LanguagesFactory languagesFactory, ILogger logger) 
		{
			_languagesFactory = languagesFactory;
			_logger = logger;
		}

		// for testing
		internal LanguageMigrator(LanguagesFactory languagesFactory, SQLiteAsyncConnection sQLiteAsyncConnection) : base(sQLiteAsyncConnection)
		{
			_languagesFactory = languagesFactory;
		}

		protected override string TableName => TableNames.Languages;

		public override async Task MigrateAsync()
		{
			try
			{
				await base.MigrateAsync();

				var languages = _languagesFactory.CreateLanguages();
				await InsertIfNotExistingAsync(languages);
			}
			catch (System.Exception e)
			{
				_logger.Log(LogLevel.Error, new LogMessage(e));
				#if DEBUG
					throw;
				#endif
			}
			
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
