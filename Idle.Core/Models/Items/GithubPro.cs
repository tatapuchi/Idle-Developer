using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Items
{
    public sealed class GithubPro : Item
    {
        public GithubPro()
        {
            Name = "Github Pro";
            Cost = 99;
            Description = "Github's Pro Plan";
            rarity = Rarity.Rare;
            itemType = ItemType.GitHubPro;
        }
    }
}
