using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class TRexKingBurger
    {
        /*
               ### T-Rex King Burger (20 points possible)

Implement a class to represent the T-Rex King Burger entree.  
Its price is **$8.45**, it contains **728 calories**, and its ingredients are: a 
**whole wheat bun, three steakburger patties, lettuce, tomato, onion, pickle, ketchup, mustard**, and **mayo**.  
* It should implement methods for holding the **bun, lettuce, tomato, onion, pickle, ketchup, mustard**, and **mayo.**
                */
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
    }
}
