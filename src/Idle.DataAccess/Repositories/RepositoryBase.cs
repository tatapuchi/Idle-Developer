using Idle.DataAccess.Common;
using SQLite;
using System.Text;

namespace Idle.DataAccess.Repositories
{


	public abstract class RepositoryBase
    {
        protected SQLiteOpenFlags Flags;
        private static SQLiteAsyncConnection _connection;
        internal SQLiteAsyncConnection Connection => _connection;

        protected RepositoryBase()
        {
            Ctor();
            _connection = new SQLiteAsyncConnection(Constants.DatabasePath, Flags);
        }

        // For testing
        protected RepositoryBase(string path)
		{
            Ctor();
            _connection = new SQLiteAsyncConnection(path);
		}

        private void Ctor()
		{
            Flags |= SQLiteOpenFlags.ReadWrite;
            Flags |= SQLiteOpenFlags.Create;
            Flags |= SQLiteOpenFlags.SharedCache;
        }

    }

	
}
