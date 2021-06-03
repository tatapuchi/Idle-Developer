using Idle.Common.Diagnostics;
using Idle.Common.Extensions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Idle.Views.Triggers
{

    public class FadeTriggerAction : TriggerAction<VisualElement>
    {
        private readonly ILogger _logger = Logger.Instance;

        public float End { get; set; } = 0.4f;
        public uint Duration { get; set; } = 1000;

        protected override async void Invoke(VisualElement sender)
        {
			try
			{
                await AwaitAsync(sender.FadeTo(End, Duration));
            }
			catch (Exception e)
			{
                _logger.Log(LogLevel.Error, new LogMessage(e));
			}
            
        }

        private static async Task AwaitAsync(Task task) => await task;

    }
}
