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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        CretaceousCombo combo;
        private bool isCombo = true;
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

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

        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
    }
}
