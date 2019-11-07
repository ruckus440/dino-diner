/* PrehistoricPBJCusomization.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PrehistoricPBJCustomization.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomization : Page
    {
        /// <summary>
        /// Private backing variable for PrehistoricPBJ
        /// </summary>
        private PrehistoricPBJ pbj;
        /// <summary>
        /// Indicates whether the PrehistoricPBJ is part of a combo
        /// </summary>
        private bool isCombo = false;

        /// <summary>
        /// Constructor for when not used in a combo
        /// </summary>
        /// <param name="pbj"></param>
        public PrehistoricPBJCustomization(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Constructor for when part of a combo
        /// </summary>
        /// <param name="pbj"></param>
        /// <param name="comboBool"></param>
        public PrehistoricPBJCustomization(PrehistoricPBJ pbj, bool comboBool)
        {
            InitializeComponent();
            this.pbj = pbj;
            isCombo = comboBool;
        }

        /// <summary>
        /// Holds the peanut butter when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        /// <summary>
        /// Holds the jelly when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// Goes back a page when the button is clicked
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
