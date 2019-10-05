/* VelociWrap.cs
 * Auther: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the VelociWrap entree menu item.
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Indicates whether dressing is included in the ingredients.
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Indicates whether lettuce is included in the ingredients.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Indicates whether parmesan cheese is included in the ingredients.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Overrides the Ingredients property in Entree.
        /// </summary>        
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructor.  Sets the Price and Calories.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;            
        }

        /// <summary>
        /// Method to hold the dressing.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Method to hold the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to hold the parmesan cheese.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
