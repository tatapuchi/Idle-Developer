using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Language
{
    public sealed class CSharp : Languages
    {
        public CSharp()
        {
            Name = "C#";
            Description = "A .NET Language";
        }


        public override string ToString()
        {
            return nameof(CSharp);
        }
    }


}

