using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Represents a SodaSaurus menu item.  Inherits from Drink.
    /// </summary>
    public class SodaSaurus : Drink
    {
        /// <summary>
        /// Sets default flavor to Cola
        /// </summary>
        private SodaSaurusFlavor flavor = SodaSaurusFlavor.Cola;
        /// <summary>
        /// Gets and Sets the Flavor
        /// </summary>
        public SodaSaurusFlavor Flavor
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
        /// Private backing Size variable
        /// </summary>
        private Size size;
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
        /// SodaSaurus constructor.  Sets default ingredients.
        /// </summary>
        public SodaSaurus()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
        }
    }
}
