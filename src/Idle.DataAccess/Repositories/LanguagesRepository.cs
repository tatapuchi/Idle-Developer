using Idle.Models.Fields;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
	public class LanguagesRepository : DbConnectionBase, IRepository<Language>
	{

		public LanguagesRepository(){ }

		internal LanguagesRepository(SQLiteAsyncConnection sQLiteAsyncConnection) : base(sQLiteAsyncConnection){ }

		public async Task<IEnumerable<Language>> GetAllAsync() =>
			await Connection.Table<Language>().ToListAsync();

		public async Task<IEnumerable<Language>> GetAllActiveLanguagesAsync() =>
			await Connection.Table<Language>().Where(lang => lang.IsActive == true).ToListAsync();

		public Task<Language> GetOrDefaultAsync(int id) =>
			Connection.Table<Language>().FirstOrDefaultAsync(model => model.ID == id);

		public Task<Language> GetOrDefaultAsync(string name) =>
			Connection.Table<Language>().FirstOrDefaultAsync(model => model.Name == name);

		public Task<int> InsertAllAsync(IEnumerable<Language> models) =>
			Connection.InsertAllAsync(models, true);

		public Task<int> InsertAsync(Language model) =>
			Connection.InsertAsync(model);

		public Task<int> RemoveAsync(Language model) =>
			Connection.DeleteAsync(model);

		public Task<int> UpdateAllAsync(IEnumerable<Language> models) =>
			Connection.UpdateAllAsync(models);

        public Task<int> UpdateAsync(Language model) => 
			Connection.UpdateAsync(model);

	}
}
