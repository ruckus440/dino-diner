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
        /// Class constructor.  Sets the Price and Calories properties.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }

        
        
    
}
