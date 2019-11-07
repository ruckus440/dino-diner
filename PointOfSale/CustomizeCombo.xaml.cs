/* CustomizeCombo.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Private backing variable for CretaceousCombo
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// Indicates whether this is part of a combo
        /// </summary>
        private bool isCombo = true;

        /// <summary>
        /// No arg constructor
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Selects the entree when the respective button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectEntree(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is Brontowurst brontowurst)
                NavigationService.Navigate(new BrontowurstCustomization(brontowurst, isCombo));
            else if (combo.Entree is DinoNuggets nuggets)
                NavigationService.Navigate(new DinoNuggetsCustomization(nuggets, isCombo));
            else if (combo.Entree is PrehistoricPBJ pBJ)
                NavigationService.Navigate(new PrehistoricPBJCustomization(pBJ, isCombo));
            else if (combo.Entree is SteakosaurusBurger burger)
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(burger, isCombo));
            else if (combo.Entree is TRexKingBurger rex)
                NavigationService.Navigate(new TRexKingBurgerCustomization(rex, isCombo));
            else if (combo.Entree is VelociWrap wrap)
                NavigationService.Navigate(new VelociWrapCustomization(wrap, isCombo));
            else
                NavigationService.Navigate(new CustomizeCombo(combo));
        }

        /// <summary>
        /// Goes to the side selection menu when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// Goes to the drink selection menu when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        
        /// <summary>
        /// Selects small when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSmall(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// Selects medium when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectMedium(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// Selects large when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
