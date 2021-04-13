using Idle.DataAccess.Common;
using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Languages;
using SQLite;
using System.Collections.Generic;

namespace Idle.DataAccess.Migrators
{
	public class LanguageMigrator : MigratorBase<LanguageBase>
	{
		public LanguageMigrator() { }
		// For testing
		internal LanguageMigrator(string path) : base(path) { }
		protected override string TableName => TableNames.Languages;

		public override void Migrate()
		{
			base.Migrate();

			var languages = new List<LanguageBase>() { new CSharp(), new Java(), new Kotlin() };
			InsertIfNotExisting(languages);
			
		}

		private void InsertIfNotExisting(IEnumerable<LanguageBase> languages)
		{
			foreach (var item in languages)
			{
				string name = item.Name;
				if (Connection.Table<LanguageBase>().Count(model => model.Name == item.Name) == 0)
					Connection.Insert(item);
			}
			
		}
	}
}
