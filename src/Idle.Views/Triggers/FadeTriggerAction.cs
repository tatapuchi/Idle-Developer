using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Idle.Views.Triggers
{
    public class FadeTriggerAction : TriggerAction<VisualElement>
    {

        public float End { get; set; } = 0.4f;
        public uint Duration { get; set; } = 1000;
        protected override void Invoke(VisualElement sender)
        {
            sender.FadeTo(End, Duration);
        }
    }
}
