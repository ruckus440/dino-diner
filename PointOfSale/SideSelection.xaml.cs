/* SideSelection.xaml.cs
 * Author: Mike Ruckert
 */

using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Private backing variable for size
        /// </summary>
        private DinoDiner.Menu.Size size { get; set; }
        /// <summary>
        /// Private backing variable for side
        /// </summary>
        private Side side;
        /// <summary>
        /// Private backing variable for combo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// No arg constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for when arriving via Side menu
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        /// <summary>
        /// Constructor for when ariving via Combo menu
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Selects the side and adds it to the order.
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    side.Size = this.size;
                    order.Add(side);
                    this.side = side;
                    NavigationService.Navigate(new Selection());
                }
            }
            else
                combo.Side = side;
        }

        /// <summary>
        /// Selects the size for the side.
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            this.size = size;
            if (side != null)
                this.side.Size = size;
            if (combo != null)
                this.combo.Side.Size = size;
        }

        /// <summary>
        /// Adds Fryceritops to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            //if (combo == null)
            //{
            //    if (DataContext is Order order)
            //    {
            //        this.side = new Fryceritops();
            //    }
            //}
            SelectSide(new Fryceritops());
        }

        public void AddMeteorMac(object sender, RoutedEventArgs args)
        {
            //if (combo == null)
            //    if (DataContext is Order order)
            //    {
            //        side = new MeteorMacAndCheese();
            //        order.Add(side);
            //    }
            //    else
            //        this.combo.Side = new MeteorMacAndCheese();

            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Adds MezzorellaSticks to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzoSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// Adds Triceritots to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// Sets size to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Sets size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Sets size to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
    }
}
