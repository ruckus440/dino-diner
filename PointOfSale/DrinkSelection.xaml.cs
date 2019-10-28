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
        private DinoDiner.Menu.Size size { get; set; }

        public Drink Drink { get; set; }
        
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
            if (drink is Sodasaurus)
            {
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = false;
                BtnSweet.IsEnabled = false;
                BtnHoldIce.IsEnabled = true;
            }
            if (drink is Tyrannotea)
            {
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnSweet.IsEnabled = true;
                BtnHoldIce.IsEnabled = true;
            }
            if (drink is JurassicJava)
            {
                BtnDecaf.IsEnabled = true;
                BtnRFCream.IsEnabled = true;
                BtnAddLemon.IsEnabled = true;
                BtnSweet.IsEnabled = false;
                BtnHoldIce.IsEnabled = false;
            }
            if (drink is Water)
            {
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnSweet.IsEnabled = false;
                BtnHoldIce.IsEnabled = true;
            }

        }

        public void DrinkSelect(Drink drink)
        {
            if (DataContext is Order order)
            {
                drink.Size = this.size;
                order.Items.Add(drink);                
                this.Drink = drink;
            }
            
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            this.size = size;
            if (Drink != null)
                this.Drink.Size = size;
        }

        private void FlavorSelect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection(this.Drink));
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
            DrinkSelect(new Tyrannotea());
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

        public void SelectSweet(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Tyrannotea tea)
            {
                if (tea.Sweet == false)
                    tea.Sweet = true;
                if (tea.Sweet == true)
                    tea.Sweet = false;
            }
        }

        public void SelectHoldIce(object sender, RoutedEventArgs args)
        {
            if (this.Drink.Ice == true)
                this.Drink.Ice = false;
            if (this.Drink.Ice == false)
                this.Drink.Ice = true;
        }

        public void SelectLemon(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Water water)
            {
                if (water.Lemon == false)
                    water.Lemon = true;
                if (water.Lemon == true)
                    water.Lemon = false;                
            }
            if (this.Drink is Tyrannotea tea)
            {
                if (tea.Lemon == false)
                    tea.Lemon = true;
                if (tea.Lemon == true)
                    tea.Lemon = false;
            }
        }

        public void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (this.Drink is JurassicJava java)
            {
                if (java.Decaf == true)
                    java.Decaf = false;
                if (java.Decaf == false)
                    java.Decaf = true;
            }
        }

        public void SelectRoomForCream(object sender, RoutedEventArgs args)
        {
            if (this.Drink is JurassicJava java)
            {
                if (java.RoomForCream == true)
                    java.RoomForCream = false;
                if (java.RoomForCream == false)
                    java.RoomForCream = true;
            }
        }

        public void DrinkDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Selection());
        }
    }
}
