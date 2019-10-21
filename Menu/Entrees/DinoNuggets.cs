/* TRexKingBurger.cs
 * Author: Mike Ruckert
 */

using System.Collections.Generic;
using System.ComponentModel;

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

        public uint extraNuggs = 0;

        /// <summary>
        /// Returns the description of this order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }        

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
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();

                if (extraNuggs > 0)
                {
                    specials.Add($"{extraNuggs} Extra Nuggets");
                    return specials.ToArray();
                }
                else
                    return specials.ToArray();
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
            extraNuggs++;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
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
