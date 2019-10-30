/* EntreeSelection.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {

        public Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }

        //public void EntreeSelect(Entree entree)
        //{
        //    if (DataContext is Order order)
        //    {
        //        order.Add(entree);
        //        this.Entree = entree;
        //    }
        //    NavigationService.Navigate(new Selection());
        //}

        /// <summary>
        /// Click to add brontowurst to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst brontowurst = new Brontowurst();
                order.Add(brontowurst);
                NavigationService.Navigate(new BrontowurstCustomization(brontowurst));
            }
        }

        /// <summary>
        /// Click to add nuggs to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggets = new DinoNuggets();
                order.Add(nuggets);
                NavigationService.Navigate(new DinoNuggetsCustomization(nuggets));
            }
        }

        /// <summary>
        /// Click to add PBJ to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new PrehistoricPBJCustomization(pbj));
            }
        }

        /// <summary>
        /// Click to add PterodactylWings to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                order.Add(wings);
                NavigationService.Navigate(new PterodactylWingsCustomization(wings));
            }
        }

        /// <summary>
        /// Click to add stekosaurus burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                order.Add(burger);
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(burger));
            }
        }

        /// <summary>
        /// Click to add Trex King Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger rex = new TRexKingBurger();
                order.Add(rex);
                NavigationService.Navigate(new TRexKingBurgerCustomization(rex));
            }
        }

        /// <summary>
        /// Click to add wrap to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                order.Add(wrap);
                NavigationService.Navigate(new VelociWrapCustomization(wrap));
            }
        }
    }
}
