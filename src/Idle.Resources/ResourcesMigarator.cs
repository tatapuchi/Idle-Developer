namespace Idle.Resources
{
	public class ResourcesMigarator : IMigrator
	{
		private readonly DirectoryMigrator _directoryMigrator;
		private readonly ImagesMigrator _imagesMigrator;

		public ResourcesMigarator(DirectoryMigrator directoryMigrator, ImagesMigrator imagesMigrator)
		{
			_directoryMigrator = directoryMigrator;
			_imagesMigrator = imagesMigrator;
		}

		public void Migrate()
		{
			_directoryMigrator.Migrate();
			_imagesMigrator.Migrate();
		}
	}
}
