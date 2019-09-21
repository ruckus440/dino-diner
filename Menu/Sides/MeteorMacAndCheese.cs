using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = .99;
                        this.Calories = 420;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };

        }
    }
}
