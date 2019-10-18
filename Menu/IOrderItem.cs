using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
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
