using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models
{
    //Top level field type for languages, frameworks and tools
    public interface Field
    {

        //Name of field eg: Java, Bootstrap, IntelliJ, etc
        public string Name { get; set; }

        //Description of field
        public string Description { get; set; }

        //Current amount of XP for a field
        public int XP { get; set; }

        //Current level for a field
        public int Level { get; set; }


        #region Listing


        //Flags to select what frameworks the user has access to
        [Flags]
        public enum Framework : long
        {
            None = 0,
            Bootstrap = 1,
            Nodejs = 2,
            React = 4,
            Angular = 8,
            Vue = 16,
            Rails = 32
        }

        //Flags to select what languages the user has access to
        [Flags]
        public enum Language : long
        {
            None = 0,
            HTML = 1,  
            CSS = 1 << 1,  
            JavaScript = 1 << 2,  
            Python = 1 << 3,  
            PHP = 1 << 4,  
            C = 1 << 5,  
            CPP = 1 << 6,  
            CSharp = 1 << 7,
            Java = 1 << 8,
            TypeScript = 1 << 9,
            Kotlin = 1 << 10,
            Dart = 1 << 11,
            Go = 1 << 12,
            Swift = 1 << 13,
            SQL = 1 << 14,
            Ruby = 1 << 15,
            ObjectiveC = 1 << 16,
            VisualBasic = 1 << 17,
            Groovy = 1 << 18,
            Scala = 1 << 19
        }

        //Flags to select what tools the user has access to
        [Flags]
        public enum Tool : long
        {
            None = 0,
            Thing = 1, 
            Monday = 2,  
            Tuesday = 4,  
            Wednesday = 8,  
            Thursday = 16,  
            Friday = 32,  
            Saturday = 64,  
            Sunday = 128 
        }

        #endregion

    }
}
