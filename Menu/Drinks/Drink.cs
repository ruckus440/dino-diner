/* Drink.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Drink base class
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredient list
        /// </summary>
        public virtual List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Sets Ice to false to hold the ice
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }

        public string[] Special 
        {
            get; 
        
        }
    }
}
