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
        /// Indicates the number of nuggets in the default order.
        /// </summary>
        public uint numNuggs = 6;
                
        /// <summary>
        /// Gets the Ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < numNuggs; i++)
                    ingredients.Add("Chicken Nugget");
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
            numNuggs++;
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
