using Idle.DataAccess.Common;
using SQLite;
using System.Text;

namespace Idle.DataAccess.Repositories
{
    public abstract class DbConnectionBase
	{
        private static readonly SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;
        
        private static SQLiteAsyncConnection _connection = new SQLiteAsyncConnection(Constants.DatabasePath, Flags);
        internal protected SQLiteAsyncConnection Connection => _connection;

        protected DbConnectionBase(){ }

        // For testing
        protected internal DbConnectionBase(SQLiteAsyncConnection sQLiteAsyncConnection)
        {
            _connection = sQLiteAsyncConnection;
        }
    }
}
