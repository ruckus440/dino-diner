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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }
        
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public void DrinkSelect(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(drink);
                this.Drink = drink;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
                this.Drink.Size = size;
        }

        private void FlavorSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        public void AddSodaSaurus(object sender, RoutedEventArgs args)
        {
            DrinkSelect(new Sodasaurus());
        }

        public void AddJurrasicJava(object sender, RoutedEventArgs args)
        {
            DrinkSelect(new JurassicJava());
        } 

        public void AddTyrannoTea(object sender, RoutedEventArgs args)
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = this.Drink.Size;
            DrinkSelect(tyrannotea);
        }

        public void AddWater(object sender, RoutedEventArgs args)
        {
            DrinkSelect(new Water());
        }

        public void SelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        public void SelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
    }
}
