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

		public async Task<IEnumerable<LanguageBase>> GetAllAsync() =>
			await Connection.Table<LanguageBase>().ToListAsync();

		public Task<LanguageBase> GetOrDefaultAsync(int id) =>
			Connection.Table<LanguageBase>().FirstOrDefaultAsync(model => model.ID == id);

		public Task<int> InsertAllAsync(IEnumerable<LanguageBase> models) =>
			Connection.InsertAllAsync(models, true);

		public Task<int> InsertAsync(LanguageBase model) =>
			Connection.InsertAsync(model);

		public Task<int> RemoveAsync(LanguageBase model) =>
			Connection.DeleteAsync(model);

		public Task<int> UpdateAsync(LanguageBase model) => 
			Connection.UpdateAsync(model);

	}
}
