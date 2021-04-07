using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Languages;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
    public abstract class RepositoryBase<TModel> where TModel: ModelBase
    {
        protected const string FileName = "idle.db3";
        protected internal string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FileName);
        protected internal SQLite.SQLiteOpenFlags Flags;
        private SQLiteAsyncConnection connection;

        protected RepositoryBase()
        {
            Flags |= SQLiteOpenFlags.ReadWrite;
            Flags |= SQLiteOpenFlags.Create;
            connection = new SQLiteAsyncConnection(DatabasePath, Flags);
        }

        public virtual void CreateAsync(TModel model) { }
        public virtual void UpdateAsync(TModel model) { }
        public virtual void RemoveAsync(TModel model) { }
        public virtual Task<TModel> GetAsync(TModel model) { return null; }

        public virtual Task<IEnumerable<TModel>> GetAllAsync(TModel model) { return null; }


    }
}
