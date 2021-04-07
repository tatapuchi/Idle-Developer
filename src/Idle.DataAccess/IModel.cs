using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    public interface IModel
    {
        // /// <summary>
        // /// Primary Key for SQLite database
        // /// </summary>
        //[AutoIncrement]
        public int ID { get; set; }
    }
}
