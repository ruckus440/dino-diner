/* SteakosarusBurger.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Steakosaurus Burger.  Inherits from the Entree class.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Indicates whether the bun is included in Ingredients.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Indicates whether pickle is included in Ingredients.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Indicates whether ketchup is included in Ingredients.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Indicates whether mustard is included in Ingredients.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Overrides Ingredients in Entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor.  Sets the Price and Calories.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Method to hold the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to hold the pickle.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Method to hold the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Method to hold the mustard.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
