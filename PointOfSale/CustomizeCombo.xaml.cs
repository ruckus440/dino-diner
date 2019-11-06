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
        private CretaceousCombo combo;
        public CretaceousCombo Combo { get; set; }
        private bool isCombo = true;
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.Combo = combo;
        }

        public void SelectEntree(object sender, RoutedEventArgs args)
        {
            if (Combo.Entree is Brontowurst brontowurst)
                NavigationService.Navigate(new BrontowurstCustomization(brontowurst, isCombo));
            else if (Combo.Entree is DinoNuggets nuggets)
                NavigationService.Navigate(new DinoNuggetsCustomization(nuggets, isCombo));
            else if (Combo.Entree is PrehistoricPBJ pBJ)
                NavigationService.Navigate(new PrehistoricPBJCustomization(pBJ, isCombo));
            else if (Combo.Entree is SteakosaurusBurger burger)
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(burger, isCombo));
            else if (Combo.Entree is TRexKingBurger rex)
                NavigationService.Navigate(new TRexKingBurgerCustomization(rex, isCombo));
            else if (Combo.Entree is VelociWrap wrap)
                NavigationService.Navigate(new VelociWrapCustomization(wrap, isCombo));
            else
                NavigationService.Navigate(new CustomizeCombo(Combo));
        }

        public void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(Combo));
        }

        public void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        
        public void SelectSmall(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Small;
        }

        public void SelectMedium(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Medium;
        }

        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
