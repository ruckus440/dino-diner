/* Entree.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that entree menu items inherit from.
    /// </summary>
    public abstract class Entree : IMenuItem
    {
        /// <summary>
        /// Indicates the price of the item.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Indicates the number of calories in the item.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Indicates the list of ingredients.  
        /// </summary>
        public List<string> Ingredients { get; set; }
    }
}
