namespace Idle.Models
{
	/// <summary>
	/// An interface that defines the cost of something in coins
	/// </summary>
	public interface ICoinCost
    {
        /// <summary>
        /// The cost of something in coins (Items are bought with coins)
        /// </summary>
        public int CoinCost { get; }
    }
}
