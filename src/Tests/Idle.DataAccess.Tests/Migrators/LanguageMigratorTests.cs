using Idle.DataAccess.Migrators;
using Idle.Models.Fields;
using Idle.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idle.DataAccess.Tests.Migrators
{
	[TestClass]	
	public class LanguageMigratorTests
	{
		[TestMethod]
		public async Task Migrate_WhenMigrated_TableExists() // todo: assert for all languages created by the languagefactory
		{
			// arrange
			var (migrator, connection) = Setup();

			// act
			await migrator.MigrateAsync();

			// assert
			var doesExist = await connection.Table<Language>().CountAsync() > 0;
			doesExist.ShouldBeTrue();
		}

		private (LanguageMigrator Migrator, SQLiteAsyncConnection Connection) Setup()
		{
			var imagesProvider = new ImagesProvider();
			var langagesFactory = new LanguagesFactory(imagesProvider);
			var connection = new SQLiteAsyncConnection(":memory:");
			var migrator = new LanguageMigrator(langagesFactory, connection);
			return (migrator, connection);
		}
	}

}
