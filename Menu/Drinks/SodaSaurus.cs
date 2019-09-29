using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class SodaSaurus : Drink
    {
        private SodaSaurusFlavor flavor = SodaSaurusFlavor.Cola;
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

        private Size size;

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

        public SodaSaurus()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
        }        
    }   
}
