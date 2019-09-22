/* MeteorMacAndCheese.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Represents the Metor Mac and Cheese side menu item.  Inherits from the Side class.
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Sets the Size of this side.
        /// </summary>
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = .99;
                        this.Calories = 420;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Class constructor.  Sets the ingredients list for this side.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };

        }
    }
}
