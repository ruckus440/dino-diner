/* Water.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Represents Water. Inherits from Drink base class.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Gets and sets lemon property
        /// </summary>
        public bool Lemon { get; set; } = false;
        public override Size Size { get; set; }
        /// <summary>
        /// Set Lemon to true.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
        /// <summary>
        /// Water constructore.  Sets Ingredient list.  Adds lemon if true.
        /// </summary>
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
            this.Ingredients = new List<string>() { "Water" };
            if (Lemon) this.Ingredients.Add("Lemon");
        }
    }
}
