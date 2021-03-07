using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Fields.Framework
{
    public sealed class Xamarin: Frameworks
    {
        public Xamarin()
        {
            Name = "Xamarin";
            Description = "A App Development Framework for C#";
            Framework = Field.Framework.Xamarin;
        }
    }
}
