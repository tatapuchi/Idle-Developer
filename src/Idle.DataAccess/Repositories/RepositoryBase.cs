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
    public class RepositoryBase<TModel> where TModel: IModel, new()
    {
        protected const string FileName = "idle.db3";
        protected internal string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FileName);
        protected internal SQLiteOpenFlags Flags;
        protected static SQLiteAsyncConnection connection;

        protected RepositoryBase()
        {
            Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
            connection = new SQLiteAsyncConnection(DatabasePath, Flags);
            connection.CreateTableAsync<TModel>();
        }

        public async virtual void InsertAsync(TModel model) { await connection.InsertAsync(model); }
        public async virtual void UpdateAsync(TModel model) { await connection.UpdateAsync(model); }
        public async virtual void DeleteAsync(TModel model) { await connection.DeleteAsync(model); }
        public async virtual Task<TModel> GetAsync(TModel model) {  return await connection.Table<TModel>().Where(i => i.ID == model.ID).FirstOrDefaultAsync(); }
        public async virtual Task<IEnumerable<TModel>> GetAllAsync() { return await connection.Table<TModel>().ToListAsync(); }


    }



}
