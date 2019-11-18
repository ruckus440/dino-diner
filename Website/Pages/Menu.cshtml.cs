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
        /// Private backing variable
        /// </summary>
        private Menu menu;

        /// <summary>
        /// Read only Menu property
        /// </summary>
        public Menu Menu { get { return menu; } }

        /// <summary>
        /// Constructor
        /// </summary>
        public void OnGet()
        {
            menu = new Menu();
        }
    }
}