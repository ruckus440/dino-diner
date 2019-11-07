/* BrontowurstCustomization.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        /// <summary>
        /// Private backing variable for Brontowurst
        /// </summary>
        private Brontowurst brontowurst;
        /// <summary>
        /// Indicates whether the Brontowurst is part of a comob
        /// </summary>
        private bool isCombo = false;

        /// <summary>
        /// Constructor for when arriving as an entree
        /// </summary>
        /// <param name="brontowurst"></param>
        public BrontowurstCustomization(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
        }

        /// <summary>
        /// Constructor for when arriving as part of a combo
        /// </summary>
        /// <param name="brontowurst"></param>
        /// <param name="comboBool"></param>
        public BrontowurstCustomization(Brontowurst brontowurst, bool comboBool)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
            isCombo = comboBool;
        }

        /// <summary>
        /// Holds the bun when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldBun();
        }

        /// <summary>
        /// Holds the brat when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBrautwurst(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldBrautwurst();
        }

        /// <summary>
        /// Holds the peppers when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldPeppers();
        }

        /// <summary>
        /// Holds the onion when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldOnion();
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
