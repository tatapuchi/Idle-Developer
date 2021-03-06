using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Items
{
    public sealed class GithubOne : Item
    {
        public GithubOne()
        {
            Name = "Github One";
            Cost = 999;
            Description = "Github's Ultimate Plan";
            rarity = Rarity.Mythical;
        }
    }
}
