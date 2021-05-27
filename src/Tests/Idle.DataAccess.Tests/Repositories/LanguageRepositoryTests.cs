using Idle.DataAccess.Migrators;
using Idle.DataAccess.Repositories;
using Idle.Models.Fields;
using Idle.Models.Fields.Languages;
using Idle.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Idle.DataAccess.Tests.Repositories
{
	[TestClass]
	public class LanguageRepositoryTests
	{
		private readonly object _setupLock = new object();

		[TestMethod]
		public async Task InsertAsync_Inserting1Language_1ShouldBeInTable()
		{
			// arrange
			var repo = await SetupAsync();
			var lang = new CSharp();

			// act
			var insertedCount = await repo.InsertAsync(lang);

			// assert
			var count = await repo.Connection.Table<Language>().CountAsync();
			count.ShouldBe(1);
			insertedCount.ShouldBe(1);

		}


		[TestMethod]
		public async Task InsertAllAsync_Inserting3Languages_3ShouldBeInTable()
		{
			// arrange
			var repo = await SetupAsync();
			var langs = new[] { new CSharp(), new CSharp(), new CSharp() };

			// act
			var addedCount = await repo.InsertAllAsync(langs);

			// assert
			var count = await repo.Connection.Table<Language>().CountAsync();
			count.ShouldBe(3);
			addedCount.ShouldBe(3);

		}

		[TestMethod]
		public async Task GetOrDefaultAsync_ReturnsInsertedItem()
		{
			// arrange
			var repo = await SetupAsync();
			const int id = 1;
			var langs = new[] { new CSharp(), new CSharp(), new CSharp() };
			var addedCount = await repo.InsertAllAsync(langs);

			// act
			var result = await repo.GetOrDefaultAsync(id);

			// assert
			result.ID.ShouldBe(id);

		}

		[TestMethod]
		public async Task GetOrDefaultAsync_WhenItemIsNotInTable_ReturnsNull()
		{
			// arrange
			var repo = await SetupAsync();
			const int missingId = 666;
			var langs = new[] { new CSharp() { ID = 1 }, new CSharp() { ID = 2 }, new CSharp() { ID = 3 } };
			var addedCount = await repo.InsertAllAsync(langs);

			// act
			var result = await repo.GetOrDefaultAsync(missingId);

			// assert
			result.ShouldBeNull();

		}

		[TestMethod]
		public async Task UpdateAsync_ChangingXp_RecordShouldBeUpdated()
		{
			// arrange
			var repo = await SetupAsync();
			var lang = new CSharp();
			await repo.InsertAsync(lang);

			// act
			lang.XP = 1337;
			var updatedCount = await repo.UpdateAsync(lang);

			// assert
			var updatedLang = await repo.Connection.Table<Language>().FirstAsync();
			updatedLang.XP.ShouldBe(1337);
			updatedCount.ShouldBe(1);
		}

		[TestMethod]
		public async Task UpdateAllAsync_ChangingXp_RecordShouldBeUpdated()
        {
			// arrange
			var repo = await SetupAsync();
			var langs = new List<Language>() { new CSharp() { ID = 1, XP = 50}, new Java { ID = 2, XP = 100}, new Kotlin { ID = 3, XP = 400} };
			await repo.InsertAllAsync(langs);

			//act
			langs[0].XP = 9001;
			langs[1].XP = 9002;
			langs[2].XP = 9003;
			var updatedCount = await repo.Connection.UpdateAllAsync(langs);

			// assert
			var updatedLangs = await repo.Connection.Table<Language>().ToListAsync();
			updatedLangs[0].XP.ShouldBe(9001);
			updatedLangs[1].XP.ShouldBe(9002);
			updatedLangs[2].XP.ShouldBe(9003);
			updatedCount.ShouldBe(3);

		}


		[TestMethod]
		public async Task RemoveAsync_AfterInserting3Languages_AndRemoving1_2ShouldBeInTable()
		{
			// arrange
			var repo = await SetupAsync();
			var toBeRemoved = new CSharp();
			var langs = new[] { toBeRemoved, new CSharp(), new CSharp() };
			await repo.InsertAllAsync(langs);

			// act
			var removedCount = await repo.RemoveAsync(toBeRemoved);

			// assert
			var count = await repo.Connection.Table<Language>().CountAsync();
			count.ShouldBe(2);
			removedCount.ShouldBe(1);
			
			var itemsInTable = await repo.Connection.Table<Language>().ToListAsync();
			itemsInTable.ShouldNotContain(toBeRemoved);

		}

		[TestMethod]
		public async Task GetAllAsync_ReturnsAllItems()
		{
			var repo = await SetupAsync();
			var langs = new[] { new CSharp(), new CSharp(), new CSharp() };
			var addedCount = await repo.InsertAllAsync(langs);

			// act
			var languages = await repo.GetAllAsync();

			// assert
			languages.Count().ShouldBe(3);

		}

		private async Task<LanguagesRepository> SetupAsync()
		{
			var connection = new SQLiteAsyncConnection(":memory:");

			var repo = new LanguagesRepository(connection);
			await repo.Connection.CreateTableAsync<Language>();
			return repo;
		}

	}
}
