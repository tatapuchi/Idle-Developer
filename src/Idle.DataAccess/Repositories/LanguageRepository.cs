using Idle.DataAccess.Fields;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Repositories
{
    public class LanguageRepository : RepositoryBase<LanguageBase>
    {
        public LanguageRepository()
        {
        }

        public override void CreateAsync(LanguageBase model)
        {
            
        }


        public override Task<IEnumerable<LanguageBase>> GetAllAsync(LanguageBase model)
        {
            throw new NotImplementedException();
        }

        public override Task<LanguageBase> GetAsync(LanguageBase model)
        {
            throw new NotImplementedException();
        }

        public override void RemoveAsync(LanguageBase model)
        {
            throw new NotImplementedException();
        }

        public override void UpdateAsync(LanguageBase model)
        {
            throw new NotImplementedException();
        }
    }
}
