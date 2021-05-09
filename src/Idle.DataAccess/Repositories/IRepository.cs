using Idle.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
	public interface IRepository<TModel>
        where TModel : ModelBase
	{
        Task<int> InsertAsync(TModel model);
        Task<int> InsertAllAsync(IEnumerable<TModel> models);
        Task<int> UpdateAsync(TModel model);
        Task<int> UpdateAllAsync(IEnumerable<TModel> models);
        Task<int> RemoveAsync(TModel model);
        Task<TModel> GetOrDefaultAsync(int id);
        Task<IEnumerable<TModel>> GetAllAsync();
	}

	
}
