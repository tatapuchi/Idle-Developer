using Idle.DataAccess.Fields;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
	public class LanguageRepository : RepositoryBase, IRepository<LanguageBase>
	{

		public LanguageRepository(){ }

		public LanguageRepository(string path) : base(path){ }

		public async Task<IEnumerable<LanguageBase>> GetKnownLanguagesAsync() =>
			await Connection.Table<LanguageBase>().Where(model => model.Level >= 10).ToListAsync();

		public async Task<IEnumerable<LanguageBase>> GetAllAsync() =>
			await Connection.Table<LanguageBase>().ToListAsync();

		public Task<LanguageBase> GetAsync(int id) =>
			Connection.Table<LanguageBase>().Where(model => model.ID == id).FirstOrDefaultAsync();

		public Task InsertAsync(LanguageBase model) =>
			Connection.InsertAsync(model);

		public Task RemoveAsync(LanguageBase model) =>
			Connection.DeleteAsync(model);

		public Task UpdateAsync(LanguageBase model) => 
			Connection.UpdateAsync(model);

		public Task DeleteAllAsync() =>
			Connection.DeleteAllAsync<LanguageBase>();

	}
}
