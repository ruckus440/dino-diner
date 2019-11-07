/* PterodactylWings.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Pterodactyl Wings entree menu item.  Inherits from the Entree class.
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// Returns the description of this order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Overrides the Ingredients property from Entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
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
                string[] str = new string[0];
                return str;
            }
        }

        /// <summary>
        /// Class constructor.  Sets the Price and Calories properties.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }

}
