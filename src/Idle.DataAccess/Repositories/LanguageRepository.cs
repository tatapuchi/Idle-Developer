using Idle.DataAccess.Fields;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
    //public class LanguageRepository: RepositoryBase<ILanguage> 
    //{
    //    public LanguageRepository()
    //    {
    //    }

    //    public async override void InsertAsync(ILanguage language)
    //    {
    //        await connection.InsertAsync(language);
    //    }

    //    public async override void DeleteAsync(ILanguage language)
    //    {
    //        await connection.DeleteAsync<ILanguage>(language);
    //    }

    //    public async override void UpdateAsync(ILanguage language)
    //    {
    //        await connection.UpdateAsync(language);
    //    }

    //    public async override Task<IEnumerable<ILanguage>> GetAllAsync()
    //    {
    //        return await connection.Table<ILanguage>().ToListAsync();
    //    }

    //    public async override Task<ILanguage> GetAsync(ILanguage language)
    //    {
    //        return await connection.Table<ILanguage>().Where(i => i.ID == language.ID).FirstOrDefaultAsync();
    //    }

    //}
}
