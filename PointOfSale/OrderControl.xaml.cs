/* OrderControl.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Gets sets the nav service
        /// </summary>
        public NavigationService NavigationService { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates when the selection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService.Navigate(new SideSelection(side));
            }
        }

        /// <summary>
        /// Removes the item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (sender is FrameworkElement frame)
                    if (frame.DataContext is IOrderItem item)
                        order.Remove(item);
        }
    }
}
