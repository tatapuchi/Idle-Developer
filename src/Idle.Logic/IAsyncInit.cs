using System.Threading.Tasks;

namespace Idle.Logic
{
	public interface IAsyncInit
	{
        Task InitializeAsync();
	}
}
