using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        private Size size;
        public bool Lemon { get; set; } = false;
        public override Size Size { get; set; }
        
        public void AddLemon()
        {
            this.Lemon = true;
        }
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
            this.Ingredients = new List<string>() { "Water" };
            if (Lemon) this.Ingredients.Add("Lemon");
        }
    }
}
