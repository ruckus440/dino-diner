/* Entree.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that entree menu items inherit from.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
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
        public virtual List<string> Ingredients { get; protected set; }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get { };
        }
    }
}
