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
        private Sodasaurus sodasaurus = new Sodasaurus();
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            if (drink is Sodasaurus soda)
                sodasaurus = soda;
        }

        public void ClickFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                sodasaurus.Flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
                NavigationService.Navigate(new DrinkSelection(sodasaurus));
            }            
        }
    }
}
