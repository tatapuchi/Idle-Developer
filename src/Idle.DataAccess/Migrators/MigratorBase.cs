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

		public MigratorBase()
		{
			_connection = new SQLiteConnection(Constants.DatabasePath);
		}

		// For testing
		internal MigratorBase(string path)
		{
			_connection = new SQLiteConnection(path);
		}

		public void Migrate()
		{
			if (DoesTableExist())
				return;

			_connection.CreateTable<TModel>();
		}

		protected abstract string TableName { get; }

		private bool DoesTableExist()
		{
			var table = _connection.Execute($"SELECT name FROM sqlite_master WHERE type = 'table' AND name = '{TableName}'");
			if (table == 0) return false;
			return true;
		}

	}
}
