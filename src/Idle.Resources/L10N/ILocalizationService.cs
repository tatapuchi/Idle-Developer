namespace Idle.Resources.L10N
{
	public interface ILocalizationService
	{
		string GetString(string key);
		bool TrySetCulture(string cultureName);
	}
}
