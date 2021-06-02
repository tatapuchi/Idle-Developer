using System.Threading.Tasks;

namespace Idle.Logic.Common
{
	public interface IAsyncInit
	{
        Task InitializeAsync();
	}
}
