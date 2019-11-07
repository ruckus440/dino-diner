/* FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda;

        public FlavorSelection()
        {
            InitializeComponent();
        }
        public FlavorSelection(Sodasaurus sodasaurus)
        {
            InitializeComponent();
            this.soda = sodasaurus;
        }

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



        //public void ClickFlavor(object sender, RoutedEventArgs args)
        //{
        //    if (sender is FrameworkElement element)
        //    {
        //        sodasaurus.Flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
        //        NavigationService.Navigate(new DrinkSelection(sodasaurus));
        //    }            
        //}
    }
}
