using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Items
{
    public sealed class GithubTeam : Item
    {
        public GithubTeam()
        {
            Name = "Github Team";
            Cost = 199;
            Description = "Github's Team Plan";
            rarity = Rarity.Epic;
        }
    }
}
