﻿using Idle.DataAccess.Repositories;
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
            await repo.InsertAsync(new CSharp() { ID=1, XP = 25, Level = 300, Grade="S++", Progress = 0.5f});
            await repo.InsertAsync(new Java() { ID = 2, XP = 35, Level = 420, Grade = "S++", Progress = 0.6f });
            await repo.InsertAsync(new Kotlin() { ID = 3, XP = 5, Level = 550, Grade = "S++", Progress = 0.4f });
            LanguagesViewModel vm = new LanguagesViewModel(repo);

            //act
            await vm.InitializeAsync();

            //assert
            vm.Languages.Count.ShouldBe(3);
            vm.Languages.FirstOrDefault(x => x.Name == "Java").Level.ShouldBe(420);
            vm.Languages.FirstOrDefault(x => x.Name == "C#").Level.ShouldBe(300);
            vm.Languages.FirstOrDefault(x => x.Name == "Kotlin").Level.ShouldBe(550);


        }


        [TestMethod]
        public async Task Progress_Update_Should_Be_Saved()
        {
            // arrange
            var repo = await SetupAsync();
            var CSharp = new CSharp() { ID = 1, XP = 25, Level = 300, Grade = "S++", Progress = 0.5f };
            await repo.InsertAsync(CSharp);
            LanguagesViewModel vm = new LanguagesViewModel(repo);
            await vm.InitializeAsync();

            // act 
            vm.Languages[0].GainProgressCommand.Execute(null);
            await vm.SaveAsync();

            // assert
            var lang = await repo.GetOrDefaultAsync(CSharp.ID);
            lang.Progress.ShouldBe(0.7f);

        }

        private async Task<LanguagesRepository> SetupAsync()
        {
            var repo = new LanguagesRepository(":memory:");
            await repo.Connection.CreateTableAsync<Language>();
            return repo;
        }

    }
}
