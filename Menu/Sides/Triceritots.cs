/* Triceritots.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class represents the Triceritots side menu item.  It inherits from the Side class.
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Sets the size of the side.  Uses Size enum from Side class.
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
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Size.ToString() + " Triceritots";
        }
    }
}
