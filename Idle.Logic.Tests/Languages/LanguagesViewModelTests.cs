using Idle.DataAccess.Repositories;
using Idle.Logic.Languages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Idle.Models.Fields;
using Idle.Models.Fields.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shouldly;
using System.Linq;
using Idle.Logic.Common;

namespace Idle.Logic.Tests.Languages
{
    [TestClass]
    public class LanguagesViewModelTests
    {
        [TestMethod]
        public async Task InitializeAsync_Should_Initialize()
        {
            // arrange
            var repo = await SetupAsync();
            await repo.InsertAsync(new CSharp() { ID=1, XP = 25, Level = 300, Grade="S++"});
            await repo.InsertAsync(new Java() { ID = 2, XP = 35, Level = 420, Grade = "S++" });
            await repo.InsertAsync(new Kotlin() { ID = 3, XP = 5, Level = 550, Grade = "S++" });
            LanguagesViewModel vm = new LanguagesViewModel(repo);

            //act
            await vm.InitializeAsync();

            //assert
            vm.Languages.Count.ShouldBe(3);
            vm.Languages.FirstOrDefault(x => x.Name == "Java").Grade.ShouldBe("S++");
            vm.Languages.FirstOrDefault(x => x.Name == "CSharp").Grade.ShouldBe("C");
            vm.Languages.FirstOrDefault(x => x.Name == "Kotlin").Grade.ShouldBe("B");

        }


        [TestMethod]
        public async Task Progress_Update_Should_Be_Saved()
        {

        }

        private async Task<LanguagesRepository> SetupAsync()
        {
            var repo = new LanguagesRepository(":memory:");
            await repo.Connection.CreateTableAsync<Language>();
            return repo;
        }

    }
}
