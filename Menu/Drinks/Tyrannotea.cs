/* Tyrannotea.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;
using System.Text;

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
        public bool Sweet { get; set; }// = false;

        /// <summary>
        /// Getter and setter to indicate Lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Tyrannotea constructor.  Builds Ingredients.
        /// </summary>
        public Tyrannotea()
        {
            this.Size = Size.Small;
            this.Sweet = false;
            this.Ingredients = new List<string>() { "Water", "Tea" };
        }

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
                if (Sweet) special.Add("Add Cane Sugar");
                return special.ToArray();
            }
        }               

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

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
                        NotifyChangeSize();
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        if (Sweet)
                        {
                            this.Price = 1.49 * 2;
                            this.Calories = 16 * 2;
                        }
                        NotifyChangeSize();
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        if (Sweet)
                        {
                            this.Price = 1.99 * 2;
                            this.Calories = 32 * 2;
                        }
                        NotifyChangeSize();
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
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sweetens the tea.
        /// </summary>
        public void Sweeten()
        {
            this.Sweet = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Description");
        }
      
        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size.ToString() + " ");
            if (Sweet)
                sb.Append("Sweet ");
            sb.Append("Tyrannotea");
            return sb.ToString();
        }
    }
}
