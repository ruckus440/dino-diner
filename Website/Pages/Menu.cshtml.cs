/* Menu.cshtml.cs
 * Author: Mike Ruckert
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Backing variable
        /// </summary>
        public Menu menu = new Menu();

        /// <summary>
        /// Binds search to html search field
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// Binds minimum price to html number input
        /// </summary>
        [BindProperty]
        public float? minPrice { get; set; }

        /// <summary>
        /// Binds maximum prics to html number input
        /// </summary>
        [BindProperty]
        public float? maxPrice { get; set; }

        /// <summary>
        /// Bind category to html checkboxes
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// Binds ingredients to html 
        /// </summary>
        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        /// <summary>
        /// Flags to hide headings
        /// </summary>
        public bool comboH2, sideH2, drinkH2, entreeH2 = false;
        

        /// <summary>
        /// Getter for possible ingredient HashSet
        /// </summary>
        public HashSet<string> PossibleIngredients { get { return menu.PossibleIngredients; } }

        /// <summary>
        /// Backing variable
        /// </summary>
        public List<IMenuItem> list;

        /// <summary>
        /// Read only Menu property
        /// </summary>
        public Menu Menu { get { return menu; } }

        /// <summary>
        /// Constructor
        /// </summary>
        public void OnGet()
        {
            list = Menu.AvailableMenuItems;
        }


        /// <summary>
        /// Functionality for search and filter options
        /// </summary>
        public void OnPost()
        {
            list = Menu.AvailableMenuItems;
            if (search != null)
                list = Menu.Search(list, search);
            if (menuCategory.Count != 0)
                list = Menu.FilterByCategory(list, menuCategory);
            if (minPrice != null || maxPrice != null)
                list = Menu.FilterByPrice(list, minPrice, maxPrice);
            if (ingredients.Count != 0)
                list = Menu.FilterByIngredients(list, ingredients);
            if (!(list.OfType<CretaceousCombo>().Any()))
                comboH2 = true;
            if (!(list.OfType<Drink>().Any()))
                drinkH2 = true;
            if (!(list.OfType<Entree>().Any()))
                entreeH2 = true;
            if (!(list.OfType<Side>().Any()))
                sideH2 = true;

        }
    }
}