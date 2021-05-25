using Idle.DataAccess.Repositories;
using Idle.Logic.Languages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Idle.Models.Fields;
using Idle.Models.Fields.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shouldly;

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
            var langs = new List<Language>() { new CSharp() { ID = 1, XP = 50 }, new Java { ID = 2, XP = 100 }, new Kotlin { ID = 3, XP = 400 } };
            await repo.InsertAllAsync(langs);
            LanguagesViewModel vm = new LanguagesViewModel(repo);

            //act
            vm.InitializeAsync();
            var langvms = vm.Languages;

            //assert
            langvms[0].XP.ShouldBe(50);
            langvms[1].XP.ShouldBe(100);
            langvms[2].XP.ShouldBe(400);

        }

        private async Task<LanguagesRepository> SetupAsync()
        {
            var repo = new LanguagesRepository(":memory:");
            await repo.Connection.CreateTableAsync<Language>();
            return repo;
        }
    }
}
