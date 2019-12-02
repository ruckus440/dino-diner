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
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        //public List<>

        /// <summary>
        /// Private backing variable
        /// </summary>
        private Menu menu = new Menu();

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
            //list = Menu.AvailableMenuItems;
            menu = new Menu();
        }

        public void OnPost()
        {
            menu = new Menu();
            if (search != null)
                list = Menu.Search(menu.AvailableMenuItems, search);
        }
    }
}