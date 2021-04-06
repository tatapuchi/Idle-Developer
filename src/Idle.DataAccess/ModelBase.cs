//using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    /// <summary>
    /// Base class for all models
    /// </summary>
    public abstract class ModelBase
    {

        // /// <summary>
        // /// Primary Key for SQLite database
        // /// </summary>
        //[AutoIncrement]
        public int ID { get; set; }

    }
}
