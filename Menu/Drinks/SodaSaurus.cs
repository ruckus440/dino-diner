﻿/* Sodasaurus.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a Sodasaurus menu item.  Inherits from Drink.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Sets default flavor to Cola
        /// </summary>
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;

        /// <summary>
        /// Gets and Sets the Flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Private backing Size variable
        /// </summary>
        private Size size;

        /// <summary>
        /// Returns the description of this order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public string[] Special
        {
            get 
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets and sets the Size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Sodasaurus constructor.  Sets default ingredients.
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();            
            sb.Append(this.Size.ToString() + " ");
            sb.Append(this.Flavor.ToString() + " ");
            sb.Append("Sodasaurus");
            return sb.ToString();
        }
    }
}
