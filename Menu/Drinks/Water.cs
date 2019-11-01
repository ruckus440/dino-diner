/* Water.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents Water. Inherits from Drink base class.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Returns the description of this order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Gets and sets lemon property
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets and sets the size property
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyOfPropertyChange("Size");
            }
        }

        /// <summary>
        /// Gets the Ingredients list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water" };
            }
        }

        /// <summary>
        /// Set Lemon to true.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
                
        /// <summary>
        /// Water constructore.  Sets Ingredient list.  Adds lemon if true.
        /// </summary>
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
            if (Lemon) this.Ingredients.Add("Lemon");
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Size.ToString() + " Water";
        }


    }
}
