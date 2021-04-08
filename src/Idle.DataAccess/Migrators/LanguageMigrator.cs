using Idle.DataAccess.Common;
using Idle.DataAccess.Fields;

namespace Idle.DataAccess.Migrators
{
	public class LanguageMigrator : MigratorBase<LanguageBase>
	{
		protected override string TableName => TableNames.Languages;
	}
}
