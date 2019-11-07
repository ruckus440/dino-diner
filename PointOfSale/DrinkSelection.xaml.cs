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
        //private DinoDiner.Menu.Size size { get; set; }

        //public Drink Drink { get; set; }
        private Drink drink;
        private CretaceousCombo combo;
        private DinoDiner.Menu.Size size { get; set; }


        public DrinkSelection()
        {
            InitializeComponent();
            BtnFlavorSelect.IsEnabled = false;
            BtnAddLemon.IsEnabled = false;
            BtnIce.IsEnabled = false;
            
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
                BtnIce.IsEnabled = true;
            }
            if (drink is Tyrannotea)
            {
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnSweet.IsEnabled = true;
                BtnIce.IsEnabled = true;
            }
            if (drink is JurassicJava)
            {
                BtnDecaf.IsEnabled = true;
                BtnRFCream.IsEnabled = true;
                BtnAddLemon.IsEnabled = true;
                BtnSweet.IsEnabled = false;
                BtnIce.IsEnabled = false;
            }
            if (drink is Water)
            {
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnSweet.IsEnabled = false;
                BtnIce.IsEnabled = true;
            }
            else
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
            }
            this.drink = drink;
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            if(drink is Sodasaurus)
            {
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = false;
                BtnIce.IsEnabled = false;
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnSweet.IsEnabled = false;                

            }
            else if (drink is Tyrannotea)
            {
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = false;
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnSweet.IsEnabled = true;
            }
            else if (drink is JurassicJava)
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = false;
                BtnIce.IsEnabled = true;
                BtnDecaf.IsEnabled = true;
                BtnRFCream.IsEnabled = true;
                BtnSweet.IsEnabled = false;
            }
            else if (drink is Water)
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = false;
                BtnDecaf.IsEnabled = false;
                BtnRFCream.IsEnabled = false;
                BtnSweet.IsEnabled = false;
            }
            else
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
            }
            this.combo = combo;
        }

        public void DrinkSelect(Drink drink)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink.Size = this.size;
                    order.Add(drink);
                    this.drink = drink;
                    NavigationService.Navigate(new Selection());
                }
            }
            else
                combo.Drink = drink;
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            this.size = size;
            if (drink != null)
                this.drink.Size = size;
            if (combo != null)
                this.combo.Drink.Size = size;
        }

        private void FlavorSelect(object sender, RoutedEventArgs args)
        {
            //NavigationService.Navigate(new FlavorSelection(this.drink));
            if (combo == null)
            {
                if (drink is JurassicJava java)
                    java.MakeDecaf();
                else if (drink is Tyrannotea tyrannotea)
                    tyrannotea.Sweeten();
                else
                {
                    Sodasaurus soda = (Sodasaurus)drink;
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
            }
            else
            {
                Sodasaurus soda = (Sodasaurus)combo.Drink;
                NavigationService.Navigate(new FlavorSelection(soda));
            }
        }

        public void AddSodaSaurus(object sender, RoutedEventArgs args)
        {
            //DrinkSelect(new Sodasaurus());
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink.Size = this.size;
                    drink = new Sodasaurus();
                    order.Add(drink);

                }
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = false;
                BtnIce.IsEnabled = false;
            }
            else
            {
                combo.Drink = new Sodasaurus();
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = false;
                BtnIce.IsEnabled = false;
            }
        }

        public void AddJurrasicJava(object sender, RoutedEventArgs args)
        {
            JurassicJava java = new JurassicJava();
            //DrinkSelect(new JurassicJava());
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    java.Size = this.size;
                    order.Add(java);
                    this.drink = java;
                    
                    BtnFlavorSelect.IsEnabled = true;
                    BtnAddLemon.IsEnabled = false;
                    BtnIce.IsEnabled = true;
                }
            }
            else
            {
                combo.Drink = java;
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = false;
                BtnIce.IsEnabled = true;
            }

        } 

        public void AddTyrannoTea(object sender, RoutedEventArgs args)
        {            
            //DrinkSelect(new Tyrannotea());
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink = new Tyrannotea();
                    order.Add(drink);
                    BtnFlavorSelect.IsEnabled = true;
                    BtnAddLemon.IsEnabled = true;
                    BtnIce.IsEnabled = true;
                }
            }
            else
            {
                combo.Drink = new Tyrannotea();
                BtnFlavorSelect.IsEnabled = true;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
            }
        }

        public void AddWater(object sender, RoutedEventArgs args)
        {
            //DrinkSelect(new Water());
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink = new Water();
                    order.Add(drink);
                    BtnFlavorSelect.IsEnabled = false;
                    BtnAddLemon.IsEnabled = true;
                    BtnIce.IsEnabled = true;
                }
            }
            else
            {
                combo.Drink = new Water();
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
            }
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
            if (drink is Tyrannotea tyrannotea)
                tyrannotea.Sweeten();
        }

        public void SelectIce(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (drink is JurassicJava java)                
                    java.AddIce();                
                else
                    drink.HoldIce();
            }
            else
            {
                if (combo.Drink is JurassicJava java)                
                    java.AddIce();                
                else
                    combo.Drink.HoldIce();
            }
                       
        }

        public void SelectLemon(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (drink is Tyrannotea tyrannotea)
                    tyrannotea.AddLemon();
                else
                {
                    Water water = (Water)drink;
                    water.AddLemon();
                }
            }
        }

        public void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (this.drink is JurassicJava java)
            {
                java.MakeDecaf();
            }
        }

        public void SelectRoomForCream(object sender, RoutedEventArgs args)
        {
            if (this.drink is JurassicJava java)
            {
                java.RoomForCream = true;
            }
        }

        public void DrinkDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Selection());
        }

        
    }
}
