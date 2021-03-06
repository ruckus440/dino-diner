﻿/* MainWindow.xaml.cs
 * Author: Mike Ruckert
 */
using System.Windows;
using System.Windows.Navigation;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderControl.NavigationService = OrderUI.NavigationService;

        }

        /// <summary>
        /// Notifies when the data context changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DataContextChange(object sender, DependencyPropertyChangedEventArgs args)
        {

        }

        /// <summary>
        /// Sets the data context
        /// </summary>
        private void SetFrameDataContext()
        {
            FrameworkElement content = OrderUI.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderUI.DataContext;
        }

        /// <summary>
        /// Data binding.  Binds data context.
        /// </summary>
        private void BindDataContextToPage()
        {
            if (OrderUI.Content is FrameworkElement element)
            {
                element.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// For data binding.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadComplete(object sender, NavigationEventArgs args)
        {
            BindDataContextToPage();
        }

        /// <summary>
        /// Click for done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (OrderUI.CanGoBack)
                OrderUI.NavigationService.GoBack();
            else
            {
                OrderUI.NavigationService.Navigate(new Selection());
            }
        }
        // Everytime we load a page we need to know what it's data context is
        // Everytime a page changes we need to notify it's data context changed
    }
}
