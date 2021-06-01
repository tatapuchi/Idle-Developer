using Idle.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.ModelTemplates.Buffs
{
    public class TestBuff : IPermaBuff
    {
        public string Name => "Test Buff";
        public float PlayerXPMultiplierAddon { get; set; } = 0f;
        public float XPMultiplierAddon { get; set; } = 0.8f;
        public float SpeedMultiplierAddon { get; set; } = 0f;
    }
}
