using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Languages;
using SQLite;
using System.Text;

namespace Idle.DataAccess.Repositories
{


	public abstract class RepositoryBase
    {
        protected internal SQLiteOpenFlags Flags;
        protected static SQLiteAsyncConnection _connection;

        protected RepositoryBase()
        {
            Ctor();
            _connection = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        // for testing
        internal RepositoryBase(string path)
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
