using Idle.DataAccess.Common;
using Idle.DataAccess.Fields;
using SQLite;

namespace Idle.DataAccess.Migrators
{
	public class LanguageMigrator : MigratorBase<LanguageBase>
	{
		// For testing
		public LanguageMigrator(string path)
		{
			_connection = new SQLiteConnection(path);
		}
		protected override string TableName => TableNames.Languages;
	}
}
