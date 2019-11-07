/* IOrderItem.cs
 * Author: Mike Ruckert
 */
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the specials for the order
        /// </summary>
        string[] Special { get; }
    }
}
