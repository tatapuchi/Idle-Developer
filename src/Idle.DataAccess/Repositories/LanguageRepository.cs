using Idle.DataAccess.Fields;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
	public class LanguageRepository : RepositoryBase, IRepository<LanguageBase>
	{
		public async Task<IEnumerable<LanguageBase>> GetAllAsync() =>
			await _connection.Table<LanguageBase>().ToListAsync();

		public Task<LanguageBase> GetAsync(int id) =>
			_connection.Table<LanguageBase>().Where(model => model.ID == id).FirstOrDefaultAsync();

		public Task InsertAsync(LanguageBase model) =>
			_connection.InsertAsync(model);

		public Task RemoveAsync(LanguageBase model) =>
			_connection.DeleteAsync(model);

		public Task UpdateAsync(LanguageBase model) => 
			_connection.UpdateAsync(model);

	}
}
