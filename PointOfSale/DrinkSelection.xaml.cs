using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
        private Drink drink;
        private CretaceousCombo combo;
        
        public DrinkSelection()
        {
            InitializeComponent();
            BtnFlavorSelect.IsEnabled = false;
            BtnAddLemon.IsEnabled = false;
            BtnAddIce.IsEnabled = false;
            
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            
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
            this.Drink = drink;
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            if(combo.Drink is Sodasaurus)
            {
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = false;
                BtnAddIce.IsEnabled = false;
                BtnHoldIce.IsEnabled = true;
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnSweet.IsEnabled = false;                

            }
            else if (combo.Drink is Tyrannotea)
            {
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = true;
                BtnAddIce.IsEnabled = false;
                BtnHoldIce.IsEnabled = true;
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnSweet.IsEnabled = true;
            }
            else if (combo.Drink is JurassicJava)
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = false;
                BtnAddIce.IsEnabled = true;
                BtnHoldIce.IsEnabled = false;
                BtnDecaf.IsEnabled = true;
                BtnRFCream.IsEnabled = true;
                BtnSweet.IsEnabled = false;
            }
            else if (combo.Drink is Water)
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnHoldIce.IsEnabled = true;
                BtnAddIce.IsEnabled = false;
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnSweet.IsEnabled = false;
            }
        }

        public void DrinkSelect(Drink drink)
        {
            if (DataContext is Order order)
            {
                drink.Size = this.size;
                order.Add(drink);                
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
            if (Drink is Tyrannotea tyrannotea)
                tyrannotea.Sweeten();
        }

        public void SelectHoldIce(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tyrannotea)
                tyrannotea.HoldIce();            
        }

        public void SelectLemon(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Water water)
            {
                water.AddLemon();            
            }
            if (this.Drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
        }

        public void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (this.Drink is JurassicJava java)
            {
                java.MakeDecaf();
            }
        }

        public void SelectRoomForCream(object sender, RoutedEventArgs args)
        {
            if (this.Drink is JurassicJava java)
            {
                java.RoomForCream = true;
            }
        }

        public void DrinkDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Selection());
        }

        public void SelectAddIce(object sender, RoutedEventArgs args)
        {
            if (this.Drink is JurassicJava java)
                java.AddIce();
        }
    }
}
