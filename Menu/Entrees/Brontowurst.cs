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
        /// Indicates whether to include brautwurst
        /// </summary>
        private bool brautwurst = true;

        /// <summary>
        /// Indicats whether to include the bun
        /// </summary>
        private bool wholeWheatBun = true;

        /// <summary>
        /// Indicates whether to include the peppers
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Indicates whether to include the onion
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Returns the description of this order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

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
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!wholeWheatBun) specials.Add("Hold Whole Wheat Bun");
                if (!brautwurst) specials.Add("Hold Brautwurst");
                if (!peppers) specials.Add("Hold Peppers");
                if (!onion) specials.Add("Hold Onion");
                return specials.ToArray();
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method for holding the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method for holding the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Method for holding brautwurst.
        /// </summary>
        public void HoldBrautwurst()
        {
            this.brautwurst = false;
        }
    }
}
