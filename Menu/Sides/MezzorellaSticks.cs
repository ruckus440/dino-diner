/* MezzorellaSticks.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the MezzorellaSticks side menu item.  Inherits from the Side class.
    /// </summary>
    public class MezzorellaSticks : Side
    {        
        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Breading", "Cheese Product", "Vegetable Oil" };
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
                        NotifyChangeSize();
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        NotifyChangeSize();
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
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
        /// Class constructor.  Sets list of ingredients.
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Size.ToString() + " Mezzorella Sticks";
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
