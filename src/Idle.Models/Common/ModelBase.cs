using SQLite;

namespace Idle.Models
{
	/// <summary>
	/// Base class for all models
	/// </summary>
	public class ModelBase
    {

        // /// <summary>
        // /// Primary Key for SQLite database
        // /// </summary>
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

    }
}
