using Idle.DataAccess.Common;
using Idle.DataAccess.Fields;
using SQLite;

namespace Idle.DataAccess.Migrators
{
	public class LanguageMigrator : MigratorBase<LanguageBase>
	{
		public LanguageMigrator() { }
		// For testing
		internal LanguageMigrator(string path) : base(path) { }
		protected override string TableName => TableNames.Languages;
	}
}
