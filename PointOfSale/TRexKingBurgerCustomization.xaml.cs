/* TRexKingBurgerCustomization.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
    {
        /// <summary>
        /// Private backing variable for TRexKingBurger
        /// </summary>
        private TRexKingBurger burger;
        /// <summary>
        /// Private backing variable to indicate when used for a combo
        /// </summary>
        private bool isCombo;

        /// <summary>
        /// Constructor for when not used as a combo
        /// </summary>
        /// <param name="burger"></param>
        public TRexKingBurgerCustomization(TRexKingBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }

        /// <summary>
        /// Constructor for used as part of a combo
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="comboBool"></param>
        public TRexKingBurgerCustomization(TRexKingBurger burger, bool comboBool)
        {
            InitializeComponent();
            this.burger = burger;
            isCombo = comboBool;
        }

        /// <summary>
        /// Holds the bun when button is clicked
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
        /// Holds the lettuce when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
        }

        /// <summary>
        /// Holds the mayo when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
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
        /// Holds the onion when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
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
        /// Holds the tomato when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
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
