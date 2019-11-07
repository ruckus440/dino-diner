/* SteakosaurusBurgerCustomization.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        /// <summary>
        /// Private backing variable for SteakosaurusBurger
        /// </summary>
        private SteakosaurusBurger burger;
        /// <summary>
        /// Indicates whether the SteakosaurusBurger is part of a combo
        /// </summary>
        private bool isCombo = false;

        /// <summary>
        /// Constructor for when not part of a combo
        /// </summary>
        /// <param name="burger"></param>
        public SteakosaurusBurgerCustomization(SteakosaurusBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }

        /// <summary>
        /// Constructor for when used as part of a combo
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="comboBool"></param>
        public SteakosaurusBurgerCustomization(SteakosaurusBurger burger, bool comboBool)
        {
            InitializeComponent();
            this.burger = burger;
            isCombo = comboBool;
        }

        /// <summary>
        /// Holds the bun when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }

        /// <summary>
        /// Holds the ketchup when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }

        /// <summary>
        /// Holds the mustard when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }

        /// <summary>
        /// Holds the pickle when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }

        /// <summary>
        /// Goes back a page when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (isCombo)
                NavigationService.GoBack();
            else
            {
                NavigationService.Navigate(new Selection());
            }
        }
    }
}
