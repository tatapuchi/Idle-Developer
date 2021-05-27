using Idle.DataAccess.Common;
using SQLite;
using System.Text;

namespace Idle.DataAccess.Repositories
{
    public abstract class DbConnectionBase
	{
        private SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;
        
        private static SQLiteAsyncConnection _connection;
        internal protected SQLiteAsyncConnection Connection => _connection;

        protected DbConnectionBase()
        {
            _connection = new SQLiteAsyncConnection(Constants.DatabasePath, Flags);
        }

        // For testing
        protected internal DbConnectionBase(SQLiteAsyncConnection sQLiteAsyncConnection)
        {
            _connection = sQLiteAsyncConnection;
        }
    }
}
