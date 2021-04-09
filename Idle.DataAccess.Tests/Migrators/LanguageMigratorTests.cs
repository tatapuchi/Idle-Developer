using Idle.DataAccess.Migrators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
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
		public void Migrate_WhenMigrated_TableExists()
		{
			// arrange
			LanguageMigrator lm = new LanguageMigrator(":memory:");
			
			// act
			lm.Migrate();

			// assert
			lm.DoesTableExist().ShouldBeTrue();
		}
	}

}
