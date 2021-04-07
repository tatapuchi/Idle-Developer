using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Idle.DataAccess.Repositories.Migrators
{
    public class BaseMigrator<TModel> where TModel : IModel, new()
    {
        protected const string FileName = "idle.db3";
        protected internal string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FileName);
        private static SQLiteConnection connection;

        public BaseMigrator()
        {
            connection = new SQLiteConnection(DatabasePath);
        }

        public virtual void Migrate()
        {
            //Not proper way to if check
            if (connection.Table<TModel>() == null)
            {
                connection.CreateTable<TModel>();
            }
        }

    }

}
