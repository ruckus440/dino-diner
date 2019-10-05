/* Side.cs
 * Author: Nathan Bean
 * Modified by: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Enumerates values for the Size property.
    /// </summary>
    //public enum Size
    //{
    //    Small,
    //    Medium,
    //    Large
    //}

    /// <summary>
    /// Abstract class that side menu items will inherit from.
    /// </summary>
    public abstract class Side : IMenuItem
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
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
