/* DinoNuggetsCustomization.xaml.cs
 * Authoer: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        /// <summary>
        /// Private backing variable for DinoNuggets
        /// </summary>
        private DinoNuggets nuggets;
        /// <summary>
        /// Indicates whether this DinoNuggets is part of a combo
        /// </summary>
        private bool isCombo = false;

        /// <summary>
        /// Constructor for when arriving as an entree
        /// </summary>
        /// <param name="nuggets"></param>
        public DinoNuggetsCustomization(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.nuggets = nuggets;
        }

        /// <summary>
        /// Constructor for when ariving as a combo
        /// </summary>
        /// <param name="nuggets"></param>
        /// <param name="comboBool"></param>
        public DinoNuggetsCustomization(DinoNuggets nuggets, bool comboBool)
        {
            InitializeComponent();
            this.nuggets = nuggets;
            isCombo = comboBool;
        }

        /// <summary>
        /// Adds a nugg when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugg(object sender, RoutedEventArgs args)
        {
            nuggets.AddNugget();
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
