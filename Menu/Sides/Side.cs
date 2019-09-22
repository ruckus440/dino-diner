/* Side.cs
 * Author: Nathan Bean
 * Modified by: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Enumerates values for the Size property.
    /// </summary>
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    /// <summary>
    /// Abstract class that side menu items will inherit from.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
