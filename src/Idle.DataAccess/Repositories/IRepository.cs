using System.Collections.Generic;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
	public interface IRepository<TModel>
        where TModel : ModelBase
	{
        Task InsertAsync(TModel model);
        Task UpdateAsync(TModel model);
        Task RemoveAsync(TModel model);
        Task<TModel> GetAsync(int id);
        Task<IEnumerable<TModel>> GetAllAsync();
	}

	
}
