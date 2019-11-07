/* ComboSelection.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// No arg constructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Selects a Brontowurst combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnBrontowurstClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst brontowurst = new Brontowurst();
                CretaceousCombo combo = new CretaceousCombo(brontowurst);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Selects a Dino Nuggets combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDinoNuggetClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggets = new DinoNuggets();
                CretaceousCombo combo = new CretaceousCombo(nuggets);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Selects a Steakosaurus combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSteakosaurusClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                CretaceousCombo combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Selects a T-Rex King Burger combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnTrexKingBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger burger = new TRexKingBurger();
                CretaceousCombo combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Selects a Pterodactyl Wings combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPterodactylWingsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                CretaceousCombo combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Selects a Prehistoric PB&J combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPrehistoricPBJClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pBJ = new PrehistoricPBJ();
                CretaceousCombo combo = new CretaceousCombo(pBJ);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Selects a VelociWrap combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnVelociwrapClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                CretaceousCombo combo = new CretaceousCombo(wrap);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
    }
}
