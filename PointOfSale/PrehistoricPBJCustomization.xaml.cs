/* PrehistoricPBJCusomization.xaml.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for PrehistoricPBJCustomization.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomization : Page
    {
        private PrehistoricPBJ pbj;
        private bool isCombo = false;

        public PrehistoricPBJCustomization(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        public PrehistoricPBJCustomization(PrehistoricPBJ pbj, bool comboBool)
        {
            InitializeComponent();
            this.pbj = pbj;
            isCombo = comboBool;
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if(isCombo)
                NavigationService.GoBack();
            else
            {
                NavigationService.Navigate(new Selection());
            }
        }


    }

    
}
