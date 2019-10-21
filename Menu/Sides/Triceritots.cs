/* Triceritots.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;

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
        /// Returns an empty string array for special instructions
        /// </summary>
        public override string[] Special
        {
            get { return new string[0]; }
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
                        NotifyChangeSize();
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        NotifyChangeSize();
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        NotifyChangeSize();
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

        /// <summary>
        /// Returns the description of this order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
    }
}
