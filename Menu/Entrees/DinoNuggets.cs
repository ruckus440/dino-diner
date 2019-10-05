/* TRexKingBurger.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the DinoNuggets entree menu item.  Inherits from the Entree class.
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Indicates the number of nuggets in the defualt order.
        /// </summary>
        public uint numNuggs = 6;

        /// <summary>
        /// Adds default nuggets to the order.
        /// </summary>
        List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget",
                                                        "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };

        /// <summary>
        /// Gets the Ingredients.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        /// <summary>
        /// DinoNuggets constructor.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * numNuggs;

        }

        /// <summary>
        /// Adds a nugget to the order.  Adjusts Price, Calories and Ingredients accordingly.
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.ingredients.Add("Chicken Nugget");
        }

        public override string ToString()
        {
            return "Dino-Nuggets";
        }

    }
}
