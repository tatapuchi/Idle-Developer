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
		protected static SQLiteConnection _connection;

		public MigratorBase()
		{
			_connection = new SQLiteConnection(Constants.DatabasePath);
		}

		// For testing
		public MigratorBase(string path)
		{
			_connection = new SQLiteConnection(path);
		}

		public bool Migrate()
		{
			if (DoesTableExist())
			{
				return false; 
			}

			_connection.CreateTable<TModel>();
			return true;
		}

		protected abstract string TableName { get; }

		private bool DoesTableExist()
		{

			var tableInfo = _connection.GetTableInfo(TableName);
			if (tableInfo.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

			//var table = _connection.Execute($"SELECT name FROM sqlite_master WHERE type = 'table' AND name = '{TableName}'");
			//if (table == 0) return false;
			//return true;
		}

	}
}
