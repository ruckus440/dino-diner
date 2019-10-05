/* Menu.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents items on the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Collects all available menu items
        /// </summary>
        public List<List<string>> AvailableMenuItems
        {
            get
            {
                List<List<string>> items = new List<List<string>>();
                items.Add(AvailableSides);
                items.Add(AvailableEntrees);
                items.Add(AvailableDrinks);
                return items;
            }
        }

        /// <summary>
        /// Collects all available entrees
        /// </summary>
        public List<string> AvailableEntrees
        {
            get
            {
                List<string> entrees = new List<string>();
                entrees.Add("Brontowurst");
                entrees.Add("Dino-Nuggets");
                entrees.Add("Prehistoric PB&J");
                entrees.Add("Pterodactyl Wings");
                entrees.Add("Steakosaurus Burger");
                entrees.Add("T-Rex King Burger");
                entrees.Add("Velociwrap");
                return entrees;
            }
        }

        /// <summary>
        /// Collects all available sides
        /// </summary>
        public List<string> AvailableSides
        {
            get
            {
                List<string> sides = new List<string>();
                sides.Add("Fryceritops");
                sides.Add("Meteor Mac and Cheese");
                sides.Add("Mezzorella Sticks");
                sides.Add("Triceritots");
                return sides;
            }
        }

        /// <summary>
        /// Collects all available drinks
        /// </summary>
        public List<string> AvailableDrinks
        {
            get
            {
                List<string> drinks = new List<string>();
                drinks.Add("Jurassic Java");
                drinks.Add("Sodasaurus");
                drinks.Add("Tyrannotea");
                drinks.Add("Water");
                return drinks;
            }
        }

        /// <summary>
        /// Collects all available combos
        /// </summary>
        public List<string> AvailableCombos
        {
            get
            {
                List<string> combos = new List<string>();
                foreach (string s in AvailableEntrees)
                {
                    combos.Add(s + " Combo");
                }
                return combos;
            }
        }

        /// <summary>
        /// Overrides the default ToString().  Returns a string with each menu on new lines.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (List<string> list in AvailableMenuItems)
            {
                foreach (string s in list)
                {
                    sb.Append(s + "\n");
                }
            }

            return sb.ToString();
        }
    }
}
