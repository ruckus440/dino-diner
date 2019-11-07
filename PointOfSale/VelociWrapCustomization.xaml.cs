/* VelociWrapCustomization.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for VelociWrapCustomization.xaml
    /// </summary>
    public partial class VelociWrapCustomization : Page
    {
        /// <summary>
        /// Private backing variable for VelociWrap
        /// </summary>
        private VelociWrap wrap;
        /// <summary>
        /// Private backing variable to indicate whether the VelociWrap is part of a combo
        /// </summary>
        private bool isCombo = false;

        /// <summary>
        /// Constructor for when not using a combo
        /// </summary>
        /// <param name="wrap"></param>
        public VelociWrapCustomization(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap;
        }

        /// <summary>
        /// Contsructor for when a combo is used
        /// </summary>
        /// <param name="wrap"></param>
        /// <param name="comboBool"></param>
        public VelociWrapCustomization(VelociWrap wrap, bool comboBool)
        {
            InitializeComponent();
            this.wrap = wrap;
            isCombo = comboBool;
        }

        /// <summary>
        /// Holds the dressing when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }

        /// <summary>
        /// Holds the lettuce when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        /// <summary>
        /// Holds the cheese when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
        }

        /// <summary>
        /// Goes back a menu screen when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (isCombo)
                NavigationService.GoBack();
            else
            {
                NavigationService.Navigate(new Selection());
            }
        }
    }
}
