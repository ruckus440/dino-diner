/* TRexKingBurger.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the T-Rex King Burger entree menu item.  Inherits from the Entree class.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Indicates whether the bun is included in Ingredients.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Indicates whether lettuce is included in Ingredients.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Indicates whether tomato is included in Ingredients.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Indicates whether onion is included in Ingredients.
        /// </summary>
        private bool onion = true;
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
        /// Indicates whether mayo is included in Ingredients.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Sets the Ingredient property.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor.  Sets the Price and Calories.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Method to hold the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to hold the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to hold the tomato.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Method to hold the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
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

        /// <summary>
        /// Method to hold the mayo.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
