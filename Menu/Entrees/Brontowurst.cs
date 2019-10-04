/* Brontowurst.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class represents the Brontowurst entree menu item.  It inherits from the Entree class.
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Booleans to indicate whether the relative ingredient is held.
        /// </summary>
        private bool brautwurst = true;
        private bool wholeWheatBun = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Get the ingredient list and returns it.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (brautwurst) ingredients.Add("Brautwurst");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor.  Sets the Price and Calories.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Method for holding the bun.
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        /// <summary>
        /// Method for holding the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Method for holding the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
