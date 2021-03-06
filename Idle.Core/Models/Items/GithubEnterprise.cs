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
        public override string Name { get; set; }
        public override int Amount { get; set; }
        public override int Cost { get; set; }
        public override int MaxStackAmount { get; set; }
        public override string Description { get; set; }
        public override Rarity rarity { get; set; }
    }
}
