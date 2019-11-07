/* Sodasaurus.cs
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
        /// Private backing flavor variable
        /// </summary>
        private SodasaurusFlavor flavor;// = SodasaurusFlavor.Cola;

        /// <summary>
        /// Private backing Size variable
        /// </summary>
        private Size size;

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
                NotifyOfPropertyChange("Description");
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
        /// Returns the description of this order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice)
                {
                    special.Add("Hold Ice");
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Ingredients");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets and sets the Size
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        //NotifyChangeSize();
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        //NotifyChangeSize();
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        //NotifyChangeSize();
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
                NotifyChangeSize();
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
