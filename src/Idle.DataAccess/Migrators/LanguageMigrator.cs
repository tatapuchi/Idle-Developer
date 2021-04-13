using Idle.DataAccess.Common;
using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Languages;
using SQLite;
using System.Linq;
using System.Collections.Generic;

namespace Idle.DataAccess.Migrators
{
	public class LanguageMigrator : MigratorBase<Language>
	{
		public LanguageMigrator() { }
		// For testing
		internal LanguageMigrator(string path) : base(path) { }
		protected override string TableName => TableNames.Languages;

		public override void Migrate()
		{
			base.Migrate();

			var languages = new List<Language>() { new CSharp(), new Java(), new Kotlin() };
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
