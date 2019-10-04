/* MezzorellaSticks.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the MezzorellaSticks side menu item.  Inherits from the Side class.
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Sets the Size property for the side.
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
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Class constructor.  Sets list of ingredients.
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Breading", "Cheese Product", "Vegetable Oil" };
        }
    }
}
