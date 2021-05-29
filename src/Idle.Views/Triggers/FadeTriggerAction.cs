using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Idle.Views.Triggers
{
    public class FadeTriggerAction : TriggerAction<VisualElement>
    {

        protected override void Invoke(VisualElement sender)
        {
            sender.FadeTo(0.4, 1000);
        }
    }
}
