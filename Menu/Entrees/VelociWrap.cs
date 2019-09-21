using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public override double Price { get; set; }
        public override uint Calories { get; set; }
        /*
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
        */

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            this.Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
            if (dressing) this.Ingredients.Add("Ceasar Dressing");
            if (lettuce) this.Ingredients.Add("Romaine Lettuce");
            if (cheese) this.Ingredients.Add("Parmesan Cheese");
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }






    }
}
