/* Tyrannotea.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Tyrannotea Drink Menu item
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Private backing size variable
        /// </summary>
        private Size size;
        /// <summary>
        /// Getter and setter to indicate Sweet
        /// </summary>
        public bool Sweet { get; set; }
        /// <summary>
        /// Getter and setter to indicate Lemon
        /// </summary>
        public bool Lemon { get; set; }
        /// <summary>
        /// Overrides the default size.  Adjusts price and calories according to Size.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = .99;
                        this.Calories = 8;
                        if (Sweet)
                        {
                            this.Price = .99 * 2;
                            this.Calories = 8 * 2;
                        }
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        if (Sweet)
                        {
                            this.Price = 1.49 * 2;
                            this.Calories = 16 * 2;
                        }
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        if (Sweet)
                        {
                            this.Price = 1.99 * 2;
                            this.Calories = 32 * 2;
                        }
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Adds lemon to the ingredients.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");
        }
        /// <summary>
        /// Sweetens the tea.
        /// </summary>
        public void Sweeten()
        {
            Sweet = true;
            this.Ingredients.Add("Cane Sugar");
        }
        /// <summary>
        /// Tyrannotea constructor.  Builds Ingredients.
        /// </summary>
        public Tyrannotea()
        {
            this.Lemon = false;
            this.Sweet = false;
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Water", "Tea" };
            if (Sweet) this.Ingredients.Add("Cane Sugar");
        }
    }
}
