﻿/* Menu.cs
 * Author: Mike Ruckert
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents items on the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Method to search the entire Menu for keywords.  Ignores case.
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public static List<IMenuItem> Search(List<IMenuItem> menuItems, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if (item.ToString().IndexOf(term, StringComparison.OrdinalIgnoreCase) >=0)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Method to filter menu items by category (Combo, Entree, Side, Drink).
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByCategory(List<IMenuItem> menuItems, List<string> category)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if (category.Contains("Combo") && item is CretaceousCombo)
                    results.Add(item);
                if (category.Contains("Entree") && item is Entree)
                    results.Add(item);
                if (category.Contains("Side") && item is Side)
                    results.Add(item);
                if (category.Contains("Drink") && item is Drink)
                    results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Filter menu items by price.
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByPrice(List<IMenuItem> menuItems, float? minPrice, float? maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if (minPrice.HasValue && maxPrice == null && item.Price >= minPrice)
                    results.Add(item);
                if (maxPrice.HasValue && minPrice == null && item.Price <= maxPrice)
                    results.Add(item);
                if (minPrice.HasValue && minPrice.HasValue && item.Price >= minPrice && item.Price <= maxPrice)
                    results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Filter menu items by ingredients.  If the ingredient checkbox is checked,
        /// menu items that contain that ingredient are not displayed.
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> menuItems, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                foreach (string ingredient in ingredients)
                {
                    if (!item.Ingredients.Contains(ingredient))
                        results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Getter for a HashSet of possible ingredients of all menu items.
        /// </summary>
        public HashSet<string> PossibleIngredients
        {
            get
            {
                HashSet<string> set = new HashSet<string>();

                foreach (IMenuItem item in AvailableMenuItems)
                    if (!(item is CretaceousCombo))
                        foreach (string ingredient in item.Ingredients)
                            set.Add(ingredient);
                return set;
            }
        }

        /// <summary>
        /// Collects all available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();
                foreach (IMenuItem item in AvailableEntrees)
                    list.Add(item);
                foreach (IMenuItem item in AvailableSides)
                    list.Add(item);
                foreach (IMenuItem item in AvailableDrinks)
                    list.Add(item);
                foreach (IMenuItem item in AvailableCombos)
                    list.Add(item);
                return list;
            }
        }

        /// <summary>
        /// Collects all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap()
                };
                return entrees;
            }
        }

        /// <summary>
        /// Collects all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return sides;
            }
        }

        /// <summary>
        /// Collects all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>
                {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
                return drinks;
            }
        }

        /// <summary>
        /// Collects all available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>();
                foreach (Entree e in AvailableEntrees)
                {
                    combos.Add(new CretaceousCombo(e));
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
            foreach (List<IMenuItem> list in AvailableMenuItems)
            {
                foreach (IMenuItem menuItem in list)
                {
                    sb.Append(menuItem.ToString() + "\n");
                }
            }
            return sb.ToString();
        }
    }
}
