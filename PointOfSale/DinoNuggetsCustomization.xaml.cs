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
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        private DinoNuggets nuggets;
        private bool isCombo = false;
        public DinoNuggetsCustomization(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.nuggets = nuggets;
        }

        public DinoNuggetsCustomization(DinoNuggets nuggets, bool comboBool)
        {
            InitializeComponent();
            this.nuggets = nuggets;
            isCombo = comboBool;
        }

        private void OnAddNugg(object sender, RoutedEventArgs args)
        {
            nuggets.AddNugget();
        }

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
