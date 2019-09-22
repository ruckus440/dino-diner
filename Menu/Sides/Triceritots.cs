/* Triceritots.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// This class represents the Triceritots side menu item.  It inherits from the Side class.
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// Sets the size of the side.  Uses Size enum from Side class.
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
                        this.Calories = 352;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Triceritots constructor.  
        /// </summary>
        public Triceritots()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
