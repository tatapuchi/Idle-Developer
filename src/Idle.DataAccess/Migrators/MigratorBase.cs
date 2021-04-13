using Idle.DataAccess.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Migrators
{
	public abstract class MigratorBase<TModel>
		where TModel : ModelBase
	{
		private static SQLiteConnection _connection;
		internal SQLiteConnection Connection => _connection;

		public MigratorBase()
		{
			_connection = new SQLiteConnection(Constants.DatabasePath);
		}

		// For testing
		internal MigratorBase(string path)
		{
			_connection = new SQLiteConnection(path);
		}

		// call base when overriding
		public virtual void Migrate()
		{
			#if DEBUG
				Connection.DropTable<TModel>();
			#endif
			if (!DoesTableExist())
			{
				Connection.CreateTable<TModel>();
			}
		}

		// Template method pettern (used with property intead of method)
		protected abstract string TableName { get; }

		internal bool DoesTableExist()
		{
			var tableInfo = Connection.GetTableInfo(TableName);

			var doesTableExist = tableInfo.Count > 0 ? true : false;
			return doesTableExist;
		}

	}
}
