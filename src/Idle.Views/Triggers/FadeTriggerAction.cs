using Idle.Common.Extensions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Idle.Views.Triggers
{
	public class FadeTriggerAction : TriggerAction<VisualElement>
    {

        public float End { get; set; } = 0.4f;
        public uint Duration { get; set; } = 1000;
        protected override async void Invoke(VisualElement sender)
        {
			try
			{
                await AwaitAsync(sender.FadeTo(End, Duration));
            }
			catch (System.Exception)
			{
				// todo: logging and no throw
			}
            
        }

        private static async Task AwaitAsync(Task task) => await task;
    }
}
