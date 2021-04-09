using Idle.DataAccess.Fields;
using Idle.DataAccess.Fields.Languages;
using Idle.DataAccess.Migrators;
using Idle.DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Tests
{
    [TestClass]
    public class RepositoryTest
    {

        //[TestMethod]
        //public void Migration()
        //{
        //    LanguageMigrator lm = new LanguageMigrator(@"C:\Users\Aorus\source\repos\Idle\Idle.DataAccess.Tests\idle.db3");
        //    lm.Migrate(); //delete after db and table is made
        //    Assert.IsFalse(lm.Migrate(), "Table already exists, do not make a new one");

        //}

        //[TestMethod]
        //public void Insertion()
        //{

        //    LanguageRepository lr = new LanguageRepository(@"C:\Users\Aorus\source\repos\Idle\Idle.DataAccess.Tests\idle.db3");
        //    CSharp cSharp = new CSharp() { XP = 50, Level = 1, Grade = "D" };
        //    lr.InsertAsync(cSharp);
        //    Assert.AreEqual(1, lr.DeleteAllAsync());

        //}

    }
}
