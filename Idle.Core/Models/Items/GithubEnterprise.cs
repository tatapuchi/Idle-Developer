using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Items
{
    public sealed class GithubEnterprise : Item
    {
        //set base maxstack amount to be 1
        public GithubEnterprise()
        {
            Name = "Github Enterprise";
            Cost = 499;
            Description = "Github's Enterprise Plan";
            rarity = Rarity.Legendary;


        }

        //for multiplayer, if a team member has github team or enterprsie plan then everyone has it
    }
}
