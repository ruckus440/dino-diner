/* FlavorSelection.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// Private backing variable for Sodasaurus
        /// </summary>
        private Sodasaurus soda;

        /// <summary>
        /// No arg constructor
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor setting default drink to Sodasaurus
        /// </summary>
        /// <param name="sodasaurus"></param>
        public FlavorSelection(Sodasaurus sodasaurus)
        {
            InitializeComponent();
            this.soda = sodasaurus;
        }

        /// <summary>
        /// Goes back a page to the drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectBack(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Sets the flavor to cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectCherry(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.GoBack();
        }

        /// <summary>
        /// Sets the flavor to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectChocolate(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Sets the flavor to cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectCola(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cola;
            NavigationService.Navigate(new DrinkSelection());

        }

        /// <summary>
        /// Sets the flavor to lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectLime(object sender, RoutedEventArgs args)
        {

            soda.Flavor = SodasaurusFlavor.Lime;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Sets the flavor to orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectOrange(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Orange;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Sets the flavor to root beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectRootBeer(object sender, RoutedEventArgs args)
        {

            soda.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.Navigate(new DrinkSelection());

        }

        /// <summary>
        /// Sets the flavor to vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectVanilla(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.Navigate(new DrinkSelection());
        }        
    }
}
