/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Represents the Prehistoric PBJ entree menu item.  Inherits from the Entree class.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Boolean to indicate whether peanut butter is held.
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Boolean to indicate whether jelly is held.
        /// </summary>
        private bool jelly = true;
        
        /// <summary>
        /// Overrides the Entree Ingredients property.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructors.  Sets the Price and Calories.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Method to hold the peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Method to hold the jelly.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
