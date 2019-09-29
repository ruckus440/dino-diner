using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size;
        public bool Sweet { get; set; }// = false;
        public bool Lemon { get; set; }// = false;

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

        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");
        }

        public void Sweeten()
        {
            Sweet = true;
            this.Ingredients.Add("Cane Sugar");
        }

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
