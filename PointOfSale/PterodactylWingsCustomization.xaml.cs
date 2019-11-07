/* PterodactylWingsCustomization.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PterodactylWingsCustomization.xaml
    /// </summary>
    public partial class PterodactylWingsCustomization : Page
    {
        /// <summary>
        /// Private backing variable for PterodactylWings
        /// </summary>
        private PterodactylWings wings;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="wings"></param>
        public PterodactylWingsCustomization(PterodactylWings wings)
        {
            InitializeComponent();
            this.wings = wings;
        }
    }
}
