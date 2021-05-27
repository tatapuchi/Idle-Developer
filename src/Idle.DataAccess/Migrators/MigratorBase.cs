using Idle.DataAccess.Common;
using Idle.DataAccess.Repositories;
using Idle.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Migrators
{
	public abstract class MigratorBase<TModel> : DbConnectionBase
		where TModel : ModelBase, new()
	{
		public MigratorBase() { }

		internal MigratorBase(SQLiteAsyncConnection sQLiteAsyncConnection) 
			: base(sQLiteAsyncConnection) { }

		// call base when overriding
		public virtual async Task MigrateAsync()
		{	
				#if DEBUG
					await Connection.DropTableAsync<TModel>();
				#endif
				var doesExist = await DoesTableExistAsync();
				if (!doesExist)
					await Connection.CreateTableAsync<TModel>();
		}


		// Template method pettern (used with property intead of method)
		protected abstract string TableName { get; }

		internal async Task<bool> DoesTableExistAsync()
		{
			var tableInfo = await Connection.GetTableInfoAsync(TableName);
			var doesTableExist = tableInfo.Count > 0 ? true : false;
			return doesTableExist;
		}

	}
}
