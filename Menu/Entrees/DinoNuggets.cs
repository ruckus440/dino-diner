using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public uint numNuggs = 6;        
        List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget",
                                                        "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };

        public double Price { get; set; }
        public uint Calories { get; set; }
        
        public List<string> Ingredients
        {
            get
            {
                return ingredients;            
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * numNuggs;
            
        }

        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            ingredients.Add("Chicken Nugget");
        }

    }
}
