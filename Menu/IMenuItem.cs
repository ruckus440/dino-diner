/* IMenuItem.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price for menu items
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Calories for menu items
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Ingredients for menu items
        /// </summary>
        List<string> Ingredients { get; }
    }
}
