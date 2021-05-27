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
using SQLite;
using Idle.Resources;
using Idle.DataAccess.Migrators;

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
            LanguagesViewModel vm = new LanguagesViewModel(repo);

            //act
            await vm.InitializeAsync();

            //assert
            vm.Languages.Count.ShouldBe(3);

        }


        [TestMethod]
        public async Task Progress_Update_Should_Be_Saved()
        {
            // arrange
            var repo = await SetupAsync();
            LanguagesViewModel vm = new LanguagesViewModel(repo);
            await vm.InitializeAsync();
            var lang = vm.Languages[0];

            // act 
            lang.GainProgressCommand.Execute(null);
            await vm.SaveAsync();

            // assert
            var model = await repo.GetOrDefaultAsync(lang.GetModel().ID);
            model.Progress.ShouldBe(0.2f);
            lang.Progress.ShouldBe(0.2f);

        }

        private async Task<LanguagesRepository> SetupAsync()
        {
            var connection = new SQLiteAsyncConnection(":memory:");

            var imagesProvider = new ImagesProvider();
            var languagesFactory = new LanguagesFactory(imagesProvider);
            var migrator = new LanguageMigrator(languagesFactory, connection);
            await migrator.MigrateAsync();

            var repo = new LanguagesRepository(connection);
            return repo;
        }

    }
}
