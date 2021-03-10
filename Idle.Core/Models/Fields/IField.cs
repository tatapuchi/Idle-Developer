using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields
{
    public interface IField
    {
        public int Level { get; set; }
        public int XP { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        //Flags to select what frameworks the user has access to
        [Flags]
        public enum FrameworkType : long
        {
            None = 0,
            BootStrap = 1,
            Nodejs = 1 << 1,
            React = 1 << 2,
            Angular = 1 << 3,
            Vue = 1 << 4,
            Rails = 1 << 5,
            LibGDX = 1 << 6,
            Flutter = 1 << 7,
            Xamarin = 1 << 8
        }

        //Flags to select what languages the user has access to
        [Flags]
        public enum LanguageType : long
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
        public enum ToolType : long
        {
            None = 0,
            GitHub = 1,
            Jenkins = 1 << 1,
            Trello = 1 << 2,
            PyCharm = 1 << 3,
            VSCode = 1 << 4,
            Atom = 1 << 5
        }



    }
}
