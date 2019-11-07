/* DrinkSelection.xaml.cs
 * Author: Mike Ruckert
 */
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

        /// <summary>
        /// Private backing variable for drink
        /// </summary>
        private Drink drink;
        /// <summary>
        /// Private backing variable for combo
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// Getter setter for size
        /// </summary>
        private DinoDiner.Menu.Size size { get; set; }

        /// <summary>
        /// No arg constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            BtnFlavorSelect.IsEnabled = false;
            BtnAddLemon.IsEnabled = false;
            BtnIce.IsEnabled = false;            
        }

        /// <summary>
        /// Constructor for when ariving from main menu
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            
            if (drink is Sodasaurus)
            {
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = false;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            if (drink is Tyrannotea)
            {
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            if (drink is JurassicJava)
            {
                BtnRFCream.IsEnabled = true;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            if (drink is Water)
            {
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = false;
            }
            else
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            this.drink = drink;
        }

        /// <summary>
        /// Constructor for when ariving from combo
        /// </summary>
        /// <param name="combo"></param>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            if (drink is Sodasaurus)
            {
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = false;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            if (drink is Tyrannotea)
            {
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            if (drink is JurassicJava)
            {
                BtnRFCream.IsEnabled = true;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            if (drink is Water)
            {
                BtnRFCream.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = false;
            }
            else
            {
                BtnFlavorSelect.IsEnabled = false;
                BtnAddLemon.IsEnabled = true;
                BtnIce.IsEnabled = true;
                BtnFlavorSelect.IsEnabled = true;
            }
            this.combo = combo;
        }

        /// <summary>
        /// Adds the drink to the menu
        /// </summary>
        /// <param name="drink"></param>
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

        /// <summary>
        /// Changes the drink size
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            this.size = size;
            if (drink != null)
                this.drink.Size = size;
            if (combo != null)
                this.combo.Drink.Size = size;
        }

        /// <summary>
        /// Changes the decaf or sweet options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void FlavorSelect(object sender, RoutedEventArgs args)
        {
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
                if (combo.Drink is JurassicJava java)
                    java.MakeDecaf();
                else if (combo.Drink is Tyrannotea tyrannotea)
                    tyrannotea.Sweeten();
                else
                {
                    Sodasaurus soda = (Sodasaurus)combo.Drink;
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
                
            }
        }

        /// <summary>
        /// Adds a soda to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSodaSaurus(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {                    
                    drink = new Sodasaurus();
                    drink.Size = this.size;
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

        /// <summary>
        /// Adds java to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddJurrasicJava(object sender, RoutedEventArgs args)
        {
            JurassicJava java = new JurassicJava();
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

        /// <summary>
        /// Add tea to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTyrannoTea(object sender, RoutedEventArgs args)
        {            
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

        /// <summary>
        /// Adds water to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddWater(object sender, RoutedEventArgs args)
        {
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

        /// <summary>
        /// Sets the size to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Sets the size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Sets the size to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        ///// <summary>
        ///// S
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="args"></param>
        //public void SelectSweet(object sender, RoutedEventArgs args)
        //{
        //    if (drink is Tyrannotea tyrannotea)
        //        tyrannotea.Sweeten();
        //}

        /// <summary>
        /// Adds or holds the ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        /// <summary>
        /// Adds lemon to the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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


        //public void SelectDecaf(object sender, RoutedEventArgs args)
        //{
        //    if (this.drink is JurassicJava java)
        //    {
        //        java.MakeDecaf();
        //    }
        //}


        /// <summary>
        /// Adds room for cream to the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectRoomForCream(object sender, RoutedEventArgs args)
        {
            if (this.drink is JurassicJava java)
            {
                java.RoomForCream = true;
            }
        }

        /// <summary>
        /// Finishes the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DrinkDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new Selection());
        }

        
    }
}
