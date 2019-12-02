/* Menu.cs
 * Author: Mike Ruckert
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents items on the menu
    /// </summary>
    public class Menu
    {
        public static List<IMenuItem> Search(List<IMenuItem> allMenuItems, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in allMenuItems)
            {
                if (item.ToString().Contains(term))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static List<IMenuItem> FilterByCategory(List<IMenuItem> allMenuItems, List<string> category)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in allMenuItems)
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
